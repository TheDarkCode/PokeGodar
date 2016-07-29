/**
           * Controller for pokemon facets
           */
.controller('pokemonFacets', function ($scope, $location, $filter, facetUrl, formatFilter) {

    // format facet field name
    $scope.fieldLabel = function (text) {
        return _.startCase(text);
    };

    // format facet value
    $scope.facetLabel = function (field, value) {
        if (field == 'pricePerSqft') {
            return $filter('dollars')(value);
        } else {
            return value;
        }
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
    $scope.facetType = { neighborhood: 'Edm.String', propertyType: 'Edm.String', pricePerSqft: 'Edm.Int32' };
    $scope.buckets = {};
    $scope.buckets.price = _.range(50e3, 500e3 + 1, 50e3)
      .concat(_.range(500e3, 1e6 + 1, 50e3))
      .concat(_.range(1e6, 5e6 + 1, 250e3))
      .concat(_.range(5e6, 10e6 + 1, 1e6));
    $scope.buckets.beds = _.range(1, 6 + 1);
    $scope.buckets.baths = [1, 1.25].concat(_.range(2, 6 + 1));
    $scope.buckets.sqft = _.range(500, 3001, 250)
      .concat(_.range(3000, 4001, 500))
      .concat(5000, 7500);
    $scope.buckets.hoa = _.range(25, 101, 25)
      .concat(_.range(100, 301, 50))
      .concat(_.range(300, 601, 100));
    $scope.buckets.domLt = [3, 7, 14, 30];
    $scope.buckets.domGt = [7, 14, 30, 60, 90, 180];



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