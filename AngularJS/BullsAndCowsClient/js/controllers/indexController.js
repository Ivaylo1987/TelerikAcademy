'use strict';

bullsAndCowsClient.controller('IndexController', ['$scope', '$location', 'appConstants', 'identity', 'authenticationService', function ($scope, $location, appConstants, identity, authenticationService) {

    $scope.authorName = appConstants.author;
    $scope.linkedInLink = "/";

    $scope.logOut = function () {
        authenticationService.logOut();
        $location.path('/home');
    };

    identity.getIdentity();
    $scope.authentication = identity;

}]);