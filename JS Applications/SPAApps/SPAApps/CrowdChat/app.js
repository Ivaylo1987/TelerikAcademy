/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
(function () {
    require.config({
        //urlArgs: "ver=" + new Date().getTime(),
        paths: {
            'jQuery': '../Scripts/jquery-2.1.1',
            'sammy': '../Scripts/sammy-0.7.4',
            'mustache': '../Scripts/mustache',
            'requester': 'HtmlRequester/requester',
            'viewLoader': 'ViewLoader/viewLoader',
            'initialViewController': 'Controllers/initialViewController',
            'chatRoomController': 'Controllers/chatRoomController'
        }
    })

    require(['jQuery'], function (jQ) {
        var mainContainer = '#main-content';
        
        require(['sammy', 'initialViewController', 'chatRoomController'], function (sammy, initialViewController, chatRoomController) {
            var app = sammy(mainContainer, function () {

                this.get('#/', function () {
                    initialViewController.run(mainContainer);
                })

                this.get('#/chatRoom', function () {
                    chatRoomController.run(mainContainer);
                })
            })
            app.run('#/');
        })
    })
}())