/**
           * Controller for pokemon map
           */
.controller('pokemonMap', function ($scope, $location, searchBounds, formatFilter, drawPolygon, currentLocation) {

    // assign map
    $scope.mapReady = function (map) {
        $scope.model.map = map;
    };

    $scope.currentLocation = function () {

        currentLocation().then(function (loc) {
            var zoom = $scope.model.map.getZoom();
            if (zoom < 12) zoom = 12;
            $scope.model.map.setView({ center: new Microsoft.Maps.Location(loc.coords.latitude, loc.coords.longitude), zoom: zoom });
        });

    };

    $scope.searchMapArea = function () {
        searchPolygon(searchBounds($scope.model.map.getBounds()));
    };

    $scope.drawPolygon = function () {
        $scope.drawing = true;
        drawPolygon($scope.model.map, function (polygon) {
            $scope.drawing = false;
            searchPolygon(polygon);
        });
    };

    function searchPolygon(points) {
        if (!points) return;
        if (points.length < 4) return;

        points = points.map(function (d) { // must be ccwise [[lat, lon]]
            return d[1] + ' ' + d[0]; // reverse for azure search
        }).join(',');

        var filter = formatFilter({
            value: points,
            type: 'Edm.GeographyPoint',
            operator: 'geo.intersects',
            name: 'location'
        });
        if ($scope.model.query.filter) {
            $scope.model.query.filter = $scope.model.query.filter.replace(/(?: and )?geo\.intersects\(\w+, geography'POLYGON\(\([^)]+\)\)'\)/, '');
        }

        $scope.model.query.filter = $scope.model.query.filter ? $scope.model.query.filter + ' and ' : '';
        $scope.model.query.filter += filter;
        $scope.model.bestView = false;
        delete $scope.model.query.q;

        $location.search($scope.model.query);
    }
})