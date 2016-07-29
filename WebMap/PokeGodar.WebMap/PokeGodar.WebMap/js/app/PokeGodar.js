angular.module('PokeGodar', ['ngRoute', 'azureSearch', 'pokemonCtrl', 'indexCtrl'])

  /**
   * Configuration
   */
    .config(function ($routeProvider) {
        $routeProvider.otherwise({
            redirectTo: '/'
        });
    });