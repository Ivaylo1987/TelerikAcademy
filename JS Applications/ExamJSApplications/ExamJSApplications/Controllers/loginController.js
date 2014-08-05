/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
define(['viewLoader', 'requester', 'sha', 'jQuery'], function (viewLoader, requester) {
    var viewURL = '../Views/loginView.html';
    var user = {};
    var loggedUser = {};

    var run = function (container, serviceURL) {
        var login = function (user, serviceURL) {
            requester.post(serviceURL, user)
                .then(function (data) {
                    sessionStorage.clear();

                    loggedUser.username = data.username;
                    loggedUser.sessionKey = data.sessionKey;

                    sessionStorage.setItem('user', JSON.stringify(loggedUser));
                    // success is log in the consol.
                    console.log('You are logged in!');

                    window.location.hash = '#/Posts';
                }, function (error) {
                    var customerError = JSON.parse(error.responseText);
                    alert(customerError.message);
                });
        }

        viewLoader.loadView(viewURL)
            .then(function (data) {
                $(container).html(data);

                $('#submit-button').on('click', function () {
                    var username = $('#name-input').val();
                    var password = $('#password-input').val();
                    var authCode = CryptoJS.SHA1(username + password).toString();

                    user.username = username;
                    user.authCode = authCode;

                    if (username.length < 6 || 40 < username.length) {
                        alert('Username should be between 6 and 40 chars');
                    } else {
                        login(user, serviceURL);
                    }
                })
            });
    };

    return {
        run: run
    }
})