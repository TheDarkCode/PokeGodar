/**
 * Controller for each pokemon in list
 */
.controller('pokemonRepeater', function ($scope) {
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