.factory('searchBounds', function () {
    return function (bounds) {
        var e = bounds.getEast()
          , w = bounds.getWest()
          , n = bounds.getNorth()
          , s = bounds.getSouth();

        return [[s, e], [n, e], [n, w], [s, w], [s, e]];
    };
})