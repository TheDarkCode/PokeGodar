.factory('currentLocation', function ($q) {
    return function () {
        var deferred = $q.defer();
        window.navigator.geolocation.getCurrentPosition(deferred.resolve, deferred.reject);
        return deferred.promise;
    };
})