/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ConsumingRemoteData\ConsumingRemoteData\Scripts/_references.js" />
var requester = (function () {
    'use strict'

    var getJSON = function (url, headers) {
        return $.ajax({
            type: 'GET',
            url: url,
            headers: headers
        });
    }

    var postJSON = function (url, data, headers) {
        return $.ajax({
            type: 'POST',
            url: url,
            data: data,
            headers: headers
        })
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    }
}())