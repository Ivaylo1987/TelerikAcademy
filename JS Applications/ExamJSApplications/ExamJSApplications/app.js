/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
(function () {
    require.config({

        paths: {
            'jQuery': 'Scripts/jquery-2.1.1',
            'sammy': 'Scripts/sammy-0.7.4',
            'q': 'Scripts/q',
            'requester': 'Requester/requester',
            'sha': 'Scripts/sha1',
            'viewLoader': 'ViewLoader/viewLoader',
            'loginController': 'Controllers/loginController',
            'logoutController': 'Controllers/logoutController',
            'registerController': 'Controllers/registerController',
            'postsController': 'Controllers/postsController'
        }
    })

    //Success messages are printed on the console.
    //Error messages are alerted.

    require(['jQuery'], function (jQ) {
        var mainContainer = '#main-content';

        require(['sammy', 'loginController', 'registerController', 'logoutController', 'postsController'], function (sammy, loginController, registerController, logoutController, postsController) {
            var app = sammy(mainContainer, function () {

                this.get('#/Posts', function () {
                    postsController.run(mainContainer, 'http://localhost:3000/post');
                })

                this.get('#/Register', function () {
                    registerController.run(mainContainer, 'http://localhost:3000/user');
                })

                this.get('#/Login', function () {
                    loginController.run(mainContainer, 'http://localhost:3000/auth');
                })

                this.get('#/Logout', function () {
                    logoutController.run(mainContainer, 'http://localhost:3000/user');
                })

            })
            app.run('#/Posts');
        })
    })
}())