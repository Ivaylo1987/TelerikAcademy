/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['jQuery'], function () {

    var makeRequest = function (url, type, data) {
        return $.ajax({
            url: url,
            type: type,
            data: data
        });
    };

    // retunrs promise
    var get = function (url) {
        return makeRequest(url, 'GET');
    }

    // returns promise
    var post = function (url, data) {
        return makeRequest(url, 'POST', data);
    }

    return {
        get: get,
        post: post
    };
})