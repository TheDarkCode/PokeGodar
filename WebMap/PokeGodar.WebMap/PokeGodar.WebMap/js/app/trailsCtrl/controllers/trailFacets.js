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