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