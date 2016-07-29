angular.module('indexCtrl', [])
  .controller('indexRoute', function () {

  })

  /**
   * Pokemons Configuration
   */
    .config(function ($routeProvider) {
        $routeProvider.when('/', {
            controller: 'indexRoute',
            templateUrl: '/js/app/indexCtrl/index.html'
        });
    });