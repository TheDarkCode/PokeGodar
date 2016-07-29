angular.module('trailsCtrl', ['mapping', 'html', 'userInput'])

    /**
     * Controller for each trail in list
     */
    .controller('trailRepeater', function ($scope) {
        $scope.focusResult = function () {
            $scope.setFocusResult($scope.doc, true);
        };
        $scope.resultMouseIn = function () {
            $scope.doc['@map.pin'].html.addClass('hover-pin');
        };
        $scope.resultMouseOut = function () {
            $scope.doc['@map.pin'].html.removeClass('hover-pin');
        };

    })

    /**
    * Controller for trail search form
    */
    .controller('trailSearchForm', function ($scope, $location, $window, suggest, cancelInput) {
        // execute search
        $scope.search = function () {
            clearSuggestions();
            $scope.allowSuggest = false;
            $location.search($scope.model.query);
            $window.setTimeout(function () {
                $scope.allowSuggest = true;
            }, 1000);
        };

        $scope.resetFilter = function () {
            delete $scope.model.query.order;
            delete $scope.model.query.filter;
            $location.search($scope.model.query);
        };

        // execute search suggestion
        $scope.suggest = function () {
            if (!$scope.model.query.q || !$scope.allowSuggest) {
                clearSuggestions();
                return;
            }

            var suggestResult = suggest('trails', {
                search: $scope.model.query.q,
                $select: 'name,county',
                $orderby: 'count desc',
                suggesterName: 'trails-sg',
                highlightPreTag: '<strong>',
                highlightPostTag: '</strong>'
            });

            suggestResult.$promise.then(function () {
                if (!$scope.allowSuggest) return;
                $scope.suggestResult = suggestResult;
                if (!$scope.cancelSuggest) {
                    $scope.cancelSuggest = cancelInput(clearSuggestions, stopSuggestions);
                }
            });
        };

        // search suggestion clicked
        $scope.clickSuggest = function (e, text) {
            $scope.model.query.q = text.replace(/<\/?strong>/g, '');
            e.stopPropagation();
            clearSuggestions();
            $scope.search();
        };

        // search box clicked
        $scope.searchInputClicked = function (e) {
            e.stopPropagation();
            $scope.suggest();
        };

        $scope.allowSuggest = true;

        // hide search suggestions
        function clearSuggestions() {
            delete $scope.suggestResult;
            if ($scope.cancelSuggest) {
                $scope.cancelSuggest();
                delete $scope.cancelSuggest;
            }
        }

        // cancel suggestions
        function stopSuggestions(keyCode) {
            if (keyCode == 27) { // ESC
                $scope.allowSuggest = false;
                clearSuggestions();
            } else if (keyCode == 9) { // TAB
                clearSuggestions();
            }
        }
    })

    /**
    * Controller for trails map
    */
    .controller('trailsMap', function ($scope, $location, searchBounds, formatFilter, drawPolygon, currentLocation) {

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

    /**
    * Controller for trail details
    */
    .controller('trailDetail', function ($scope) {

        // advance detail document image preview
        // Not used with trails
        //$scope.nextImage = function () {
        //    if ($scope.model.detail['@image'] == $scope.model.detail.imageUrls.length - 1) {
        //        $scope.model.detail['@image'] = 0;
        //    } else {
        //        $scope.model.detail['@image']++;
        //    }
        //};
    })

    /**
    * Controller for sorting results
    */
    .controller('trailSort', function ($scope, $location) {

        $scope.$watch('model.query.order', function (newValue) {
            if (newValue) {
                var parts = newValue.split(' ');
                $scope.orderBy = { field: parts[0], label: $scope.orderFields[parts[0]] };
                $scope.orderDir = parts[1] || 'asc';
            }
        });

        $scope.orderFields = {
            elevation: 'elevation',
            location: 'distance'
        };

        $scope.toggleDirUrl = function () {
            if (!$scope.orderBy) return;
            var urlParams = angular.copy($location.search())
                      , path = $location.path()
              , dir = $scope.orderDir == 'asc' ? 'desc' : 'asc';

            urlParams.order = $scope.orderBy.field + ' ' + dir;
            return '#' + path + '?' + $.param(urlParams, true);
        };

        $scope.orderUrl = function (field) {
            var urlParams = angular.copy($location.search())
                      , path = $location.path();

            urlParams.order = field + ' ' + $scope.orderDir;
            return '#' + path + '?' + $.param(urlParams, true);
        };
    })

    /**
    * Controller for pokemon facets
    */
    .controller('trailFacets', function ($scope, $location, $filter, facetUrl, formatFilter) {

        // format facet field name
        $scope.fieldLabel = function (text) {
            return _.startCase(text);
        };

        // format facet value
        $scope.facetLabel = function (field, value) {
            return value;
        };

        $scope.applyFilter = function () {
            // var filters = {}//parseFilter($scope.model.query.filter);
            _.each($scope.filter, function (v, k) {
                if (v.min) {
                    $scope.model.filters[k + 'ge'] = {
                        name: k,
                        type: 'Edm.Double',
                        comparison: 'ge',
                        value: v.min
                    };
                } else if (v.min === null) {
                    delete $scope.model.filters[k + 'ge'];
                }

                if (v.max) {
                    $scope.model.filters[k + 'le'] = {
                        name: k,
                        type: 'Edm.Double',
                        comparison: 'le',
                        value: v.max
                    };
                } else if (v.max === null) {
                    delete $scope.model.filters[k + 'le'];
                }
            });
            $scope.model.query.filter = _.values($scope.model.filters).map(formatFilter).join(' and ');
            $location.search($scope.model.query);
        };

        // URL helper functions
        $scope.facetUrl = facetUrl;

        $scope.filter = {};
        $scope.facetType = { county: 'Edm.String', elevation: 'Edm.Int64' };
        //$scope.buckets = {};



        _.each($scope.model.filters, function (d) {
            if ($scope.buckets[d.name]) {
                if (d.comparison == 'ge') {
                    $scope.filter[d.name] = $scope.filter[d.name] || {};
                    $scope.filter[d.name].min = d.value;
                } else if (d.comparison == 'le') {
                    $scope.filter[d.name] = $scope.filter[d.name] || {};
                    $scope.filter[d.name].max = d.value;
                }
            }
        });
    })

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
                $scope.model.map.setView({ animate: true, center: $scope.model.detail['@map.location'], zoom: 10 });
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
        $scope.model.query.order = $scope.model.query.order;
        $scope.refreshResults();
    })

    /**
     * Trails Configuration
     */
    .config(function ($routeProvider) {
        $routeProvider.when('/trails', {
            controller: 'trailsRoute',
            templateUrl: '/js/app/trailsCtrl/trails.html',
            reloadOnSearch: false
        });
    });