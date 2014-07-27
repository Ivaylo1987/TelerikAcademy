﻿/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['requester'], function (requester) {

    // loads the view into a predefined HTML container
    var loadView = function (container, ViewPath) {
        var deferred = $.Deferred();

        return requester.get(ViewPath).then(function (data) {
            $(container).append(data);
            deferred.resolve();
        }, function (error) {
            deferred.reject(error);
        });

        return deferred.promise();
    }
    
    return {
        loadView: loadView
    }
})