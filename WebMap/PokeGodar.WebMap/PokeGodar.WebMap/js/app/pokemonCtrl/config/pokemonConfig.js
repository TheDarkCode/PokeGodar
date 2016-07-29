/**
 * Pokemons Configuration
 */
.config(function ($routeProvider) {
    $routeProvider.when('/pokemon', {
        controller: 'pokemonRoute',
        templateUrl: 'views/pokemon.html',
        reloadOnSearch: false
    });
});