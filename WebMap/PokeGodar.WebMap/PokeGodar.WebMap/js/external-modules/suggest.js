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