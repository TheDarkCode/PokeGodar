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