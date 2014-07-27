/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
(function () {
    require.config({
        //urlArgs: "ver=" + new Date().getTime(),
        paths: {
            'jQuery': '../Scripts/jquery-2.1.1',
            'sammy': '../Scripts/sammy-0.7.4',
            'requester': 'HtmlRequester/requester',
            'viewLoader': 'ViewLoader/viewLoader'
        }
    })

    require(['jQuery', 'viewLoader'], function (jQ, viewLoader) {
        var mainContainer = '#main-content';
        
        require(['sammy'], function (sammy) {
            var app = sammy(mainContainer, function () {

                this.get('#/', function () {
                    viewLoader.loadView(mainContainer, 'Views/initianlView.html');
                })
            })



            app.run('#/');
        })
    })
}())