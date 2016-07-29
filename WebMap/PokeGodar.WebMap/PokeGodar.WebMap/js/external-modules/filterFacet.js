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