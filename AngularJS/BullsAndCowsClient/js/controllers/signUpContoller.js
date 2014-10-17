"use strict";

bullsAndCowsClient.controller('SignUpController', ['$scope', '$location', '$timeout', 'authenticationService',
    function LoginController($scope, $location, $timeout, authenticationService) {
        $scope.savedSuccessfully = false;
        $scope.message = "";

        $scope.registration = {
            userName: "",
            password: "",
            confirmPassword: ""
        };

        $scope.signUp = function () {

            authenticationService.register($scope.registration)
                .then(function (response) {
                    $scope.savedSuccessfully = true;
                    $scope.message = "User has been registered successfully, you will be redirected to Login page in 2 seconds.";
                    startTimer();
                }, function (response) {
                    var errors = [];
                    for (var key in response.data.modelState) {
                        for (var i = 0; i < response.data.modelState[key].length; i++) {
                            errors.push(response.data.modelState[key][i]);
                        }
                    }

                    $scope.message = "Failed to register user due to:" + errors.join(' ');
                });
        };

        var startTimer = function () {
            var timer = $timeout(function () {
                $timeout.cancel(timer);
                $location.path('/login');
            }, 2000);
        }
    }]);
