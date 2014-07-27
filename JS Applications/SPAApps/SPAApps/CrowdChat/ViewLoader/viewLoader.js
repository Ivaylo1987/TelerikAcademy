/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['requester'], function (requester) {

    // loads the view into a predefined HTML container and returns promise
    var loadView = function (ViewPath) {
        var deferred = $.Deferred();

        requester.get(ViewPath).then(function (data) {
            deferred.resolve(data);
        }, function (error) {
            deferred.reject(error);
        });

        return deferred.promise();
    }
    
    return {
        loadView: loadView
    }
})