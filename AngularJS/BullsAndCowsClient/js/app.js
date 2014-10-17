"use strict";

var bullsAndCowsClient = angular.module('bullsAndCowsClient', ['ngRoute', 'LocalStorageModule']);

// TODO: Fix links
bullsAndCowsClient.constant("appConstants", {
    author: 'Ivo Hristov',
    baseUrl: 'http://localhost:49428',
    loginUrl: '/Token',
    registerUrl: '/api/Account/Register',
    logOutUrl: '/..'
});

bullsAndCowsClient.config(function ($routeProvider) {

    $routeProvider.when('/home', {
        templateUrl: '../views/home.html',
        controller: 'HomeController'
    })

    $routeProvider.when('/games', {
        templateUrl: '../views/games.html'
        //controller: 'GamesController',
    })

    $routeProvider.when('/signup', {
        templateUrl: '../views/signup.html',
        controller: 'SignUpController'
    })

    $routeProvider.when('/login', {
        templateUrl: '../views/login.html',
        controller: 'LoginController'
    })

    $routeProvider.otherwise({ redirectTo: '/home'});
});

bullsAndCowsClient.config(function ($httpProvider) {
    $httpProvider.interceptors.push('interceptorService');
});