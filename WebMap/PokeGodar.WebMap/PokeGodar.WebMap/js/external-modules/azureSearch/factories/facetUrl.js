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