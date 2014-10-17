'use strict';
bullsAndCowsClient.factory('authenticationService', ['$http', '$q', 'localStorageService', 'appConstants', 'identity', function ($http, $q, localStorageService, appConstants, identity) {

    var serviceBase = appConstants.baseUrl;
    var loginUrl = appConstants.loginUrl;
    var registerUrl = appConstants.registerUrl;
    var authServiceFactory = {};

    var register = function (registration) {
        logOut();

        var data = "Email=" + registration.userName + "&password=" + registration.password + "&confirmPassword=" + registration.password;

        return $http.post(serviceBase + registerUrl, data, {
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            }
        });
    };

    var login = function (loginData) {
        var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

        var deferred = $q.defer();

        $http.post(serviceBase + loginUrl, data,
            { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
            .success(function (response) {
                var tokenData ={
                    token: response.access_token,
                    userName: loginData.userName
                };

                identity.setIdentity(tokenData);
                identity.isAuth = true;
                identity.userName = loginData.userName;

                deferred.resolve(response);
            }).error(function (err, status) {
                deferred.reject(err);
            });

        return deferred.promise;
    };

    var logOut = function logOut() {
        identity.setIdentity(undefined);
        identity.isAuth = false;
        identity.userName = "";
    };

    authServiceFactory.register = register;
    authServiceFactory.login = login;
    authServiceFactory.logOut = logOut;

    return authServiceFactory;
}]);