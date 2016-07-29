.factory('tokenizeFilters', function () {
    var SPACE = ' ', EMPTY = '', QUOTE = '\'', BACKSLASH = '\\', OPEN_PAREN = '(', CLOSE_PAREN = ')', AND = 'and', OR = 'or', NOT = 'not'
      , BREAKERS = [SPACE, CLOSE_PAREN]
      , LOGICAL = [AND, OR, NOT]
      , PARENS = [OPEN_PAREN, CLOSE_PAREN]
      , ANY = 'any', FIELD = 'field', COMPARE = 'compare', VALUE = 'value', STRING_VALUE = 'value.string'
      , GEO_INTERSECTS = 'geo.intersects', GEO_INTERSECTS_FIELD = 'geo.intersects.field', GEO_INTERSECTS_POLYGON = 'geo.intersects.polygon', GEO_INTERSECTS_VALUE = 'geo.intersects.polygon.value'
      , GEO_DISTANCE = 'geo.distance', GEO_DISTANCE_FIELD = 'geo.distance.field', GEO_DISTANCE_POINT = 'geo.distance.point', GEO_DISTANCE_VALUE = 'geo.distance.point.value'
    ;

    function tokenizeGeoIntersects(state) {
        if (state.expect != GEO_INTERSECTS) throw new Error('Invalid state. Expecting ' + state.expect);
        if (state.buffer != GEO_INTERSECTS) throw new Error('Invalid state. Exepected buffer');

        var filter = {};
        filter.operator = GEO_INTERSECTS;
        filter.type = 'Edm.GeographyPoint';
        state.expect = GEO_INTERSECTS_FIELD;
        state.emptyBuffer();
        state.i++;

        for (state.i; state.i < state.expression.length; state.i++) {
            if (state.expect == GEO_INTERSECTS_FIELD && state.char() == ',') {
                filter.name = state.buffer;
                state.expect = GEO_INTERSECTS_POLYGON;
                state.emptyBuffer();
                state.i++;
            } else if (state.expect == GEO_INTERSECTS_POLYGON && state.buffer == ' geography\'POLYGON((') {
                state.expect = GEO_INTERSECTS_VALUE;
                state.emptyBuffer();
            } else if (state.expect == GEO_INTERSECTS_VALUE && state.char() == ')') {
                filter.value = state.buffer;
                state.emptyBuffer();
                state.expect = ANY;
                state.i += 4;
                if (state.char() == SPACE) {
                    state.i++;
                } else {
                    state.i--;
                }
                return filter;
            }

            state.appendBuffer();
        }
    }

    function tokenizeGeoDistance(state) {
        if (state.expect != GEO_DISTANCE) throw new Error('Invalid state. Expecting ' + state.expect);
        if (state.buffer != GEO_DISTANCE) throw new Error('Invalid state. Exepected buffer');

        var filter = {};
        filter.operator = GEO_DISTANCE;
        filter.type = 'Edm.GeographyPoint';
        state.expect = GEO_DISTANCE_FIELD;
        state.emptyBuffer();
        state.i++;

        for (state.i; state.i < state.expression.length; state.i++) {

            if (state.expect == GEO_DISTANCE_FIELD && state.char() == ',') {
                filter.name = state.buffer;
                state.expect = GEO_DISTANCE_POINT;
                state.emptyBuffer();
                state.i++;
            } else if (state.expect == GEO_DISTANCE_POINT && state.buffer == ' geography\'POINT(') {
                state.expect = GEO_DISTANCE_VALUE;
                state.emptyBuffer();
            } else if (state.expect == GEO_DISTANCE_VALUE && state.char() == ')') {
                filter.point = state.buffer;
                state.emptyBuffer();
                state.expect = GEO_DISTANCE_POINT;
            } else if (state.expect == GEO_DISTANCE_POINT && state.buffer == ')\') ') {
                state.emptyBuffer();
                state.expect = COMPARE;
                filter.comparison = tokenizeComparison(state);
                var value = tokenizeValue(state);
                filter.value = value.value;
                return filter;
            }

            state.appendBuffer();
        }
    }

    function tokenizeFilter(state) {
        if (state.expect != FIELD) throw new Error('Invalid state. Expecting ' + state.expect);
        if (state.char() != SPACE) throw new Error('Invalid state. Expected [space] character');
        if (!state.buffer.length) throw new Error('Invalid state. Exepected non-empty buffer');

        var filter = {};
        filter.name = state.buffer;
        state.emptyBuffer();

        state.expect = COMPARE;
        state.i++; // consume space character
        filter.comparison = tokenizeComparison(state);

        var value = tokenizeValue(state);
        filter.value = value.value;
        filter.type = value.type;

        return filter;
    }

    function tokenizeComparison(state) {
        if (state.expect != COMPARE) throw new Error('Invalid state. Expecting ' + state.expect);
        if (state.buffer.length) throw new Error('Invalid state. Exepected empty buffer');

        for (state.i; state.i < state.expression.length; state.i++) {
            if (state.expect == COMPARE && state.char() == SPACE && state.buffer.length) {
                var comparison = state.buffer;
                state.emptyBuffer();
                state.expect = VALUE;
                state.i++; // consume space character
                return comparison;
            }
            state.appendBuffer();
        }
    }

    function tokenizeValue(state) {
        if (state.expect != VALUE) throw new Error('Invalid state. Expecting ' + state.expect);
        var token = {};
        for (state.i; state.i < state.expression.length; state.i++) {


            if (state.expect == VALUE && state.char() == QUOTE) {
                state.expect = STRING_VALUE;
            } else if (state.expect == STRING_VALUE && state.char() == QUOTE && state.prevChar() != BACKSLASH) {
                if (state.nextChar() == SPACE) {
                    state.i++;
                }
                break;
            } else if (state.expect == VALUE && BREAKERS.indexOf(state.char()) != -1) {
                if (state.char() != SPACE) {
                    state.i--;
                }
                break;
            } else {
                state.appendBuffer();
            }
        }

        token.value = state.buffer;
        tokenType(token);
        state.emptyBuffer();
        state.expect = ANY;
        return token;

        function tokenType(token) {
            if (state.expect == STRING_VALUE) {
                token.type = 'Edm.String';
            } else {
                var int = parseInt(token.value);
                if (_.isNumber(int)) {
                    var float = parseFloat(token.value);
                    if (int == float) {
                        token.value = int;
                        token.type = 'Edm.Int32';
                    } else {
                        token.value = float;
                        token.type = 'Edm.Double';
                    }
                }
            }
        }
    }

    return function (expression) {
        var state = { i: 0, expression: expression, expect: ANY, buffer: EMPTY }
          , tokens = [];

        if (!expression) {
            return tokens;
        }

        state.char = function () {
            return state.expression[state.i];
        };
        state.prevChar = function () {
            return state.expression[state.i - 1];
        };
        state.nextChar = function () {
            return state.expression[state.i + 1];
        };
        state.appendBuffer = function () {
            state.buffer += state.char();
        };
        state.emptyBuffer = function () {
            state.buffer = EMPTY;
        };



        for (state.i; state.i < state.expression.length; state.i++) {

            // token: geo.intersects filter
            if (state.expect == ANY && state.buffer == GEO_INTERSECTS) {
                state.expect = GEO_INTERSECTS;
                tokens.push(tokenizeGeoIntersects(state));

                // token: geo.distance filter
            } else if (state.expect == ANY && state.buffer == GEO_DISTANCE) {
                state.expect = GEO_DISTANCE;
                tokens.push(tokenizeGeoDistance(state));

                // token: logical operator
            } else if (state.expect == ANY && state.char() == SPACE && LOGICAL.indexOf(state.buffer) != -1) {
                tokens.push(state.buffer);
                state.emptyBuffer();
                continue;

                // token: parens
            } else if (state.expect == ANY && PARENS.indexOf(state.char()) != -1) {
                tokens.push(state.char());
                state.emptyBuffer();
                if (state.nextChar() == SPACE) {
                    state.i++;
                }
                continue;

                // token filter
            } else if (state.expect == ANY && state.char() == SPACE && state.buffer.length) {
                state.expect = FIELD;
                tokens.push(tokenizeFilter(state));
                continue;
            }

            state.appendBuffer();
        }

        return tokens;
    };
})