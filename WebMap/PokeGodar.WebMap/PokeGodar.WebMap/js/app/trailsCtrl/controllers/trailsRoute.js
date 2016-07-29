/**
 * Controller for main trails route
 */
.controller('trailsRoute', function ($scope, $location, $sce, currentLocation, search, bestView, groupFilters) {

    // return cleansed HTML
    $scope.html = function (text) {
        return $sce.trustAsHtml(text);
    };

    // manually refresh results since route disables reloadOnSearch
    $scope.$on('$routeUpdate', function (a, b) {
        $scope.model.query = b.params;
        $scope.refreshResults();
    });

    // set detail document
    $scope.setFocusResult = function (doc, centerMap) {
        if ($scope.model.detail) {
            $scope.model.detail['@map.pin'].html.removeClass('active-pin');
            $scope.model.detail['@active'] = false;
        }
        $scope.model.detail = doc;
        $scope.model.detail['@image'] = 0;
        $scope.model.detail['@active'] = true;
        $scope.model.detail['@map.pin'].html.addClass('active-pin');
        if (centerMap) {
            $scope.model.map.setView({ animate: true, center: $scope.model.detail['@map.location'], zoom: 20 });
        } else {
            $scope.model.detail['@scrollTo']();
        }
    };

    // refresh results
    $scope.refreshResults = function () {
        $scope.loading = true;
        var searchParams = {
            //search: "",
            search: $scope.model.query.q,
            searchMode: 'all',
            $orderby: $scope.model.query.order,
            $filter: $scope.model.query.filter || null,
            $top: 100,
            $count: true,
            facet: [
              'county',
              'elevation,values:100|300|500|700|1000|1500|2000|2500'
            ]
        };

        var result;
        if (_.startsWith($scope.model.query.order, 'location')) {
            var parts = $scope.model.query.order.split(' ')
              , field = parts[0]
              , dir = parts[1] || 'asc';
            result = { $promise: currentLocation() };
            result.$promise = result.$promise.then(function (loc) {
                var lon = loc.coords.longitude, lat = loc.coords.latitude;
                searchParams.$orderby = 'geo.distance(' + field + ", geography'POINT(" + lon + ' ' + lat + ")') " + dir;
                return search('trails', searchParams).$promise;
            });
        } else {
            result = search('trails', searchParams);
        }

        if ($scope.model.map) $scope.model.map.entities.clear();


        $scope.model.filters = groupFilters($scope.model.query.filter);

        result.$promise.then(function (data) {
            $scope.loading = false;
            if ($scope.model.detail) delete $scope.model.detail;
            $scope.result = data;
            var locations = [], pins = {};
            data.value = data.value.filter(function (d) {
                return d.location;
            });
            data.value.forEach(function (d, i) {
                d['@map.location'] = new Microsoft.Maps.Location(d.location.coordinates[1], d.location.coordinates[0]);
                d['@map.pin'] = new Microsoft.Maps.Pushpin(d['@map.location'], {
                    htmlContent: '<span class="map-pin"></span>',
                    anchor: new Microsoft.Maps.Point(10, 10),
                    width: 20,
                    height: 20
                });
                d['@map.pin'].document = d;
                d['@map.pin'].html = $();
                d['@scrollTo'] = function () {
                    $('#result-list').find('li').get(i).scrollIntoView();
                };

                $scope.model.map.entities.push(d['@map.pin']);
                locations.push(d['@map.location']);
                pins[i] = d['@map.pin'];

                Microsoft.Maps.Events.addHandler(d['@map.pin'], 'click', function (e) {
                    $scope.$apply(function () {
                        $scope.setFocusResult(e.target.document);
                    });
                });
                Microsoft.Maps.Events.addHandler(d['@map.pin'], 'mouseover', function (e) {
                    e.target.html.addClass('hover-pin');
                });
                Microsoft.Maps.Events.addHandler(d['@map.pin'], 'mouseout', function (e) {
                    e.target.html.removeClass('hover-pin');
                });
            });

            // find pushpin DOM nodes
            var maxCycles = 10;
            (function findPushpins() {
                _.each(pins, function (v, k) {
                    if (v.cm1002_er_etr) {
                        v.html = $(v.cm1002_er_etr.dom).find(':first-child');
                        if (v === data.value[0]['@map.pin']) {
                            setTimeout(function () {
                                Microsoft.Maps.Events.invoke(v, 'click', { target: v });
                            });
                        }
                        delete pins[k];
                    }
                });

                if (_.size(pins) > 0 && --maxCycles > 0) {
                    setTimeout(findPushpins);
                }
            })();

            if ($scope.model.bestView !== false) {
                $scope.model.map.setView(bestView(locations));
            }
            $scope.model.bestView = true;
        });
    };

    // main
    $scope.model = {};
    $scope.model.query = $location.search();
    $scope.model.query.order = $scope.model.query.order || 'location';
    $scope.refreshResults();
})