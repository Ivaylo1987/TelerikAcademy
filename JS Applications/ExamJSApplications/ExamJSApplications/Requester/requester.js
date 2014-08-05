/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
define(['q', 'jQuery'], function (Q) {

    var makeRequest = function (url, type, data, headers) {
        var deferred = Q.defer();

        $.ajax({
            url: url,
            type: type,
            data: data,
            headers: headers,
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.reject(error);
            }
        });

        return deferred.promise;
    };

    // returns promise
    var get = function (url) {
        var deferred = Q.defer();

        makeRequest(url, 'GET')
            .then(function (data) {
                deferred.resolve(data);
            }, function (error) {
                deferred.reject(error);
            });

        return deferred.promise;
    }

    // returns promise
    var put = function (url, data, headers) {
        var deferred = Q.defer();

        makeRequest(url, 'PUT', data, headers)
            .then(function (data) {
                deferred.resolve(data);
            }, function (error) {
                deferred.reject(error);
            });

        return deferred.promise;
    }

    // returns promise
    var post = function (url, data, headers) {
        var deferred = Q.defer();

        makeRequest(url, 'POST', data, headers)
            .then(function (data) {
                deferred.resolve(data);
            }, function (error) {
                deferred.reject(error);
            });


        return deferred.promise;
    }

    return {
        get: get,
        post: post,
        put: put
    };
})