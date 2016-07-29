angular.module('azureSearch', ['ngResource'])
  .constant('searchKey', '')
  .constant('searchService', '')
  .constant('searchVersion', '2015-02-28')
  .constant('dateFormat', 'YYYY-MM-DDTHH:mm:ssZ')

  .factory('groupFilters', function (tokenizeFilters) {
      return function (expression) {
          return _(tokenizeFilters(expression))
            .filter(_.isObject)
            .indexBy(function (d) {
                return d.name + d.comparison;
            })
            .value();
      };
  })

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

  .factory('parseFilter', function () {
      return function (expression) {
          if (!expression) return {};
          return _(expression.split(' and '))
            .indexBy(function (d) {
                return d.split(' ').slice(0, 2).join('');
            })
            .mapValues(parseFilter)
            .value();
      };

      function parseFilter(text) {
          var parts = text.split(' ')
            , value = parts.slice(2).join(' ')
            , isString = _.startsWith(value, "'")
            , type = isString ? 'Edm.String' : 'Edm.Double';

          if (isString) {
              value = value.substr(1, value.length - 2);
          } else {
              value = parseFloat(value);
          }

          return { name: parts[0], comparison: parts[1], value: value, type: type };
      }
  })

  .factory('search', function ($resource, searchService, searchKey, searchVersion) {
      var url = 'https://' + searchService + '.search.windows.net/indexes/:index/docs'
        , defaults = { 'api-version': searchVersion, 'api-key': searchKey }
        , search = $resource(url, defaults);
      return function (index, params) {
          if (!index) throw new Error('Index not set');
          params = params || {};
          params.index = index;
          return search.get(params);
      };
  })

  .factory('suggest', function ($resource, searchService, searchKey, searchVersion) {
      var url = 'https://' + searchService + '.search.windows.net/indexes/:index/docs/suggest'
        , defaults = { 'api-version': searchVersion, 'api-key': searchKey }
        , suggest = $resource(url, defaults);
      return function (index, params) {
          if (!index) throw new Error('Index not set');
          params = params || {};
          params.index = index;
          return suggest.get(params);
      };
  })

  // return a filtered URL for the specified facet    
  .factory('facetUrl', function ($location, filterFacet) {
      return function (field, facet, type, queryParam) { // TODO factory
          var urlParams = angular.copy($location.search())
              , path = $location.path();

          queryParam = queryParam || 'filter';
          urlParams[queryParam] = urlParams[queryParam] ? urlParams[queryParam] + ' and ' : '';
          urlParams[queryParam] += filterFacet({
              field: field,
              from: facet.from,
              to: facet.to,
              value: facet.value,
              type: type
          });
          return '#' + path + '?' + $.param(urlParams, true);
      };
  })

  // return a filtered URL for the specified field
  .factory('filterUrl', function ($location, formatFilter) {
      return function (field, fieldType, comparison, value) { // TODO factory
          var urlParams = angular.copy($location.search())
                    , path = $location.path();

          urlParams.filter = urlParams.filter ? urlParams.filter + ' and ' : '';
          urlParams.filter += formatFilter({
              name: field,
              type: fieldType,
              comparison: comparison,
              value: value
          });

          return '#' + path + '?' + $.param(urlParams, true);
      };
  })

  .factory('filterFacet', function (formatFilter, dateFormat) {

      function calcInterval(value, interval) {
          throw 'Date not implemented';
          var float = parseFloat(interval);
          if (float) {
              return parseFloat(value) + float;
          }

          var date = moment(value, dateFormat);

          return date.add(1, interval).format(dateFormat);
      }

      return function (params) {

          // values to
          if (params.to && !params.from) {
              return formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.to,
                  comparison: 'lt'
              });

              // values to+from
          } else if (params.to && params.from) {
              return formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.from,
                  comparison: 'ge'
              }) + ' and ' + formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.to,
                  comparison: 'lt'
              });

              // values from
          } else if (!params.to && params.from) {
              return formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.from,
                  comparison: 'ge'
              });

              // interval
          } else if (params.interval) {
              var intervalValue = calcInterval(params.value, params.interval);
              return formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.value,
                  comparison: 'ge'
              }) + ' and ' + formatFilter({
                  name: params.field,
                  type: params.type,
                  value: intervalValue,
                  comparison: 'lt'
              });

              // basic equality
          } else {
              return formatFilter({
                  name: params.field,
                  type: params.type,
                  value: params.value
              });
          }
      };
  })

  .factory('formatFilter', function () {
      function value(fieldType, val) {
          if (fieldType == 'Edm.String') {
              if (val.toString().indexOf("'") !== 0) val = "'" + val;
              if (val.toString().lastIndexOf("'") != val.length - 1) val += "'";
              return val;
          } else if (fieldType.indexOf('Edm.Int') === 0) {
              return parseInt(val) || 0;
          } else if (fieldType == 'Edm.Double') {
              return parseFloat(val);
          } else if (fieldType == 'Edm.Boolean') {
              if (angular.isString(val)) {
                  return val.toLowerCase() == 'true';
              } else if (val === true || val === false) {
                  return val;
              } else {
                  return !!val;
              }
          } else {
              return val;
          }
      }
      function lambda(field, exp, val) {
          exp = exp || '/any eq'; // TODO
          var parts = exp.split(' ')
              , fieldType = 'Edm.String';
          return field + parts[0] + '(x:x ' + parts[1] + ' ' + value(fieldType, val) + ')';
      }
      function geoDistance(field, point, comparison, val) {
          return 'geo.distance(' + field + ', geography\'POINT(' + point + ')\')' + ' ' + comparison + ' ' + value('Edm.Double', val);
      }
      function geoIntersects(field, points) {
          return 'geo.intersects(' + field + ', geography\'POLYGON((' + points + '))\')';
      }

      return function (params) { // type, name, comparison, value [,point, operator]
          if (params.type.indexOf('Collection(') === 0) {
              return lambda(params.name, params.comparison, params.value);
          } else if (params.type == 'Edm.GeographyPoint') {
              if (params.operator == 'geo.distance') {
                  return geoDistance(params.name, params.point, params.comparison, params.value);
              } else if (params.operator == 'geo.intersects') {
                  return geoIntersects(params.name, params.value);
              }
          } else {
              params.comparison = params.comparison || 'eq';
              return params.name + ' ' + params.comparison + ' ' + value(params.type, params.value);
          }
      };
  });