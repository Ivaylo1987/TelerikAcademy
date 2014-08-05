define(['q', 'requester'], function (Q, requester) {

    // loads the view into a predefined HTML container and returns promise
    var loadView = function (ViewPath) {
        var deferred = Q.defer();

        requester.get(ViewPath).then(function (data) {
            deferred.resolve(data);
        }, function (error) {
            deferred.reject(error);
        });

        return deferred.promise;
    }

    return {
        loadView: loadView
    }
})