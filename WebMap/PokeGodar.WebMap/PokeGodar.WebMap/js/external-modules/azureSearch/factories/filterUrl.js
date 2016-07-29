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