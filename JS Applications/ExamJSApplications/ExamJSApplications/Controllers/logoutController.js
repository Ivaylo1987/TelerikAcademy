/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
define(['viewLoader', 'requester', 'jQuery'], function (viewLoader, requester) {
    var viewURL = '../Views/logoutView.html';
    var user = {};

    var run = function (container, serviceURL) {

        viewLoader.loadView(viewURL)
            .then(function (data) {
                $(container).html(data);

                $('#submit-button').on('click', function () {
                    if (sessionStorage.length !== 0) {

                        var input = JSON.parse(sessionStorage.getItem('user'));
                        var sessionKey = input.sessionKey;
                        var headers = { 'X-SessionKey': sessionKey };

                        requester.put(serviceURL, true, headers)
                            .then(function (data) {
                                // success is log in the consol.
                                console.log('You are logged out');

                                sessionStorage.clear();
                                window.location.hash = '#/Posts'
                            }, function (error) {
                                var customerError = JSON.parse(error.responseText);
                                alert(customerError.message);
                            });

                    }
                    else {
                        window.location.hash = '#/Posts'
                    }

                })
            });
    };

    return {
        run: run
    }
})