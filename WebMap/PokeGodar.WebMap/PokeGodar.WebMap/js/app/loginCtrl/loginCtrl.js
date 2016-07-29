(function () {
    'use strict';

    angular.module('PokeGodar')
        .controller('loginCtrl', ["$location", "authService", "eventAggregator", function ($location, authService, eventAggregator) {
            var vm = this;

            vm.login = {};
            vm.success = false;
            vm.message = "";

            //vm.submitLoginForm = function (isValid) {
            //    authService.login(vm.login).then(function (response) {
            //        vm.success = true;
            //        //eventAggregator.trigger("isAuthenticated", true);
            //        $location.path("/pokemon");
            //    }, function (err) {
            //        vm.message = err.error_description;
            //    });
            //};

        }]);
})();