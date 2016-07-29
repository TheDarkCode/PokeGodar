angular.module('PokeGodar', ['ngRoute', 'azureSearch', 'templates', 'pokemonCtrl', 'indexCtrl'])

  /**
   * Configuration
   */
    .config(function ($routeProvider) {
        $routeProvider.otherwise({
            redirectTo: '/'
        });
    });