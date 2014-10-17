"use strict";
bullsAndCowsClient.factory('identity', ['localStorageService',function Identity(localStorageService) {
    var identity = {
        isAuth: false,
        userName: "",
        getIdentity: function () {
            var authData = localStorageService.get('authorizationData');

            return authData;
        },
        setIdentity: function (data) {
            if (data) {
                localStorageService.set('authorizationData', { token: data.access_token, userName: data.userName });
            }
            else{
                localStorageService.remove('authorizationData');
            }
        }
    };

    return identity;
}]);