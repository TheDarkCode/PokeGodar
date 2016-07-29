(function () {
    'use strict';

    angular.module('PokeGodar')
        .controller('confirmEmailController', ["$routeParams", "authService", function ($routeParams, authService) {
            var vm = this;

            vm.title = "Processing request... please wait.";
            vm.message = "";

            var userId = $routeParams.userId;
            var code = $routeParams.code;
            console.log("confirming email - userId: " + userId + " - code: " + code);

            authService.confirmEmail(userId, code).then(function (response) {
                vm.message = "Congratulations, you have been verified! ";
                vm.title = "Congratulations!";
                vm.success = true;
            }, function (err) {
                vm.title = "Doh!";
                console.log(angular.toJson(err));
                vm.message = err.error_description;
                vm.success = false;
            });

        }]);
})();