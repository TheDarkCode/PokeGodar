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