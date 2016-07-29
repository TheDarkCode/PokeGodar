.factory('cancelInput', function ($rootScope) {
    var count = 0;
    return function (clickCancel, keyCancel) {
        var id = count++;
        keyCancel = keyCancel || clickCancel;
        $(window).on('click.' + id, function () {
            $rootScope.$apply(clickCancel);
        }).on('keyup.' + id, function (e) {
            $rootScope.$apply(function () {
                keyCancel(e.keyCode);
            });
        });

        function off() {
            $(window).off('click.' + id).off('keyup.' + id);
        }

        return off;
    };
});