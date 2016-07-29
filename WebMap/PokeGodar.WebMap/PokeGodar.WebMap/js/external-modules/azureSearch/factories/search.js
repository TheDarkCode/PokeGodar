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