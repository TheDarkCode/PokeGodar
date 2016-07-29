.filter('dollars', function ($filter) {
    return function (value, precision) {
        return $filter('currency')(value, '$', precision || 0);
    };
})