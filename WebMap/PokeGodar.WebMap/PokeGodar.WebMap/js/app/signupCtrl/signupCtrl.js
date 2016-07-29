(function () {
    'use strict';

    angular.module('PokeGodar')
        .controller('signupCtrl', ["authService", function (authService) {
            var vm = this;

            vm.registration = {};
            vm.savedSuccessfully = false;
            vm.message = "";

            vm.submitSignupForm = function (isValid) {

                authService.saveRegistration(vm.registration).then(function (response) {

                    vm.savedSuccessfully = true;
                    vm.message = "You have registered successfully!  Please check your email to activate your account.";

                },
                 function (response) {
                     console.log(angular.toJson(response));
                     var errors = [];
                     for (var key in response.data.ModelState) {
                         for (var i = 0; i < response.data.ModelState[key].length; i++) {
                             errors.push(response.data.ModelState[key][i]);
                         }
                     }
                     vm.message = errors.join(' ');
                 });
            };

        }]);
})();