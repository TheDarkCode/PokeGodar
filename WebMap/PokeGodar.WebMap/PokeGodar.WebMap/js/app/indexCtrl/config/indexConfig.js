/**
 * Pokemons Configuration
 */
.config(function ($routeProvider) {
    $routeProvider.when('/', {
        controller: 'indexRoute',
        templateUrl: 'views/index.html'
    });
});