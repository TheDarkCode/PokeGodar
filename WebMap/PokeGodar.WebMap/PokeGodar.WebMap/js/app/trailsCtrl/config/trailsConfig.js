/**
 * Trails Configuration
 */
.config(function ($routeProvider) {
    $routeProvider.when('/trails', {
        controller: 'trailsRoute',
        templateUrl: '/js/app/trailsCtrl/trails.html',
        reloadOnSearch: false
    });
});