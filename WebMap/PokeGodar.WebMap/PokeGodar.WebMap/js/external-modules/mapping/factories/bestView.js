.factory('bestView', function () {
    return function (locations) {
        var length = _.uniq(locations, false, function (d) {
            return d.latitude + ',' + d.longitude;
        }).length;

        if (length == 1) {
            return { center: locations[0], zoom: 11 };
        } else if (length > 1) {
            return { bounds: Microsoft.Maps.LocationRect.fromLocations(locations) };
        } else {
            return {};
        }
    };
})