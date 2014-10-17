var myApp = angular.module('myApp', ['ngResource' , 'ngRoute']);

myApp.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: "../partials/example.html",
            controller: 'MainPageController'
        })
        .otherwise({ redirectTo: '/'});
});
