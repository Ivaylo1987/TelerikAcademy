'use strict';
bullsAndCowsClient.controller('LoginController', ['$scope', '$location', 'authenticationService', function ($scope, $location, authInterceptorService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.message = "";

    $scope.login = function () {
        authInterceptorService.login($scope.loginData).then(function (response) {
            $location.path('/games');
        }, function (err) {
            if (err) {
                $scope.message = err.error_description;
            }
        });
    };
}]);