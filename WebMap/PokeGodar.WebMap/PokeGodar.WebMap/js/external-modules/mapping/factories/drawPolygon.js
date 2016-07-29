.factory('drawPolygon', function ($rootScope) {
    var Maps = Microsoft.Maps
      , handlers = [];

    function removeListeners() {
        handlers.forEach(function (d) {
            Maps.Events.removeHandler(d);
        });
        handlers.length = 0;
    }

    return function (map, callback) {
        var polygon = new Maps.Polygon([], { fillColor: new Maps.Color(100, 204, 204, 204), strokeColor: new Maps.Color(200, 142, 40, 0), strokeThickness: 1 })
          , line = new Maps.Polyline([], { strokeColor: new Maps.Color(200, 142, 40, 0), strokeThickness: 1, strokeDashArray: '5 2' })
          , cursor = $('.MicrosoftMap').css('cursor');

        removeListeners();
        line.setLocations([]);
        line.setOptions({ visible: true });
        polygon.setLocations([]);
        map.entities.clear();
        map.entities.push(polygon);
        map.entities.push(line);

        handlers.push(Maps.Events.addHandler(map, 'mousedown touchstart', mapMouseDown));
        handlers.push(Maps.Events.addHandler(map, 'mousemove touchmove', mapMouseMove));
        handlers.push(Maps.Events.addHandler(map, 'mouseup touchend', mapMouseUp));
        handlers.push(Maps.Events.addHandler(map, 'dblclick', mapDblClick));
        handlers.push(Maps.Events.addHandler(map, 'keyup', mapKeyUp));

        function mapMouseDown(e) {
            if (!e.handled && e.targetType == 'map') {
                $('.MicrosoftMap').css('cursor', 'crosshair');
                var point = new Maps.Point(e.getX() - 2, e.getY() - 2)
                  , loc = e.target.tryPixelToLocation(point)
                  , locs = polygon.getLocations() || [];
                locs.push(loc);
                polygon.setLocations(locs);
                e.handled = true;
            }
        }

        function mapMouseMove(e) {
            if (!e.handled && e.targetType == 'map') {
                $('.MicrosoftMap').css('cursor', 'crosshair');
                var point = new Maps.Point(e.getX() - 2, e.getY() - 2)
                  , loc = e.target.tryPixelToLocation(point)
                  , locs = polygon.getLocations() || [];
                if (locs.length) {
                    line.setLocations([locs[locs.length - 1], loc]);
                }
                e.handled = true;
            }
        }
        function mapMouseUp(e) {
            if (!e.handled && e.targetType == 'map') {
                e.handled = true;
            }
        }
        function mapDblClick(e) {
            completePolygon();
            e.handled = true;
        }
        function mapKeyUp(e) {
            if (e.keyCode == 27) { // ESC
                polygon.setLocations([]);
                line.setLocations([]);
                removeListeners();
                $('.MicrosoftMap').css('cursor', cursor);
                $rootScope.$apply(function () {
                    callback(null);
                });
            } else if (e.keyCode == 13) { // ENTER
                completePolygon();
            }
        }
        function completePolygon() {
            $('.MicrosoftMap').css('cursor', cursor);
            var locs = polygon.getLocations();
            locs.push(locs[0]);
            polygon.setLocations(locs);
            line.setOptions({ visible: false });
            removeListeners();
            $rootScope.$apply(function () {
                callback(polygon.getLocations().map(function (d) {
                    return [d.latitude, d.longitude];
                }));
            });
        }
    };
});