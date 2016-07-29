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