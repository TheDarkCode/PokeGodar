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