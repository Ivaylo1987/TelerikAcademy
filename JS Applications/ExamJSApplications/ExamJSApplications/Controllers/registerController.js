/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
define(['viewLoader', 'requester', 'sha', 'jQuery'], function (viewLoader, requester) {
    var viewURL = '../Views/registerView.html';

    var run = function (container, serviceURL) {

        var register = function (user, serviceURL) {
            requester.post(serviceURL, user)
                .then(function (data) {
                    // success is log in the consol.
                    console.log('registered');

                    window.location.hash = '#/Login';
                }, function (error) {
                    var customerError = JSON.parse(error.responseText);
                    alert(customerError.message);
                });
        }

        viewLoader.loadView(viewURL)
            .then(function (data) {
                $(container).html(data);

                $('#submit-button').on('click', function () {
                    var user = {};
                    var username = $('#name-input').val();
                    var password = $('#password-input').val();
                    var authCode = CryptoJS.SHA1(username + password).toString();

                    user.username = username;
                    user.authCode = authCode;

                    if (username.length < 6 || 40 < username.length) {
                        alert('Username should be between 6 and 40 chars');
                    }
                    else {
                        register(user, serviceURL);
                    }

                })
            });
    };

    return {
        run: run
    }
})