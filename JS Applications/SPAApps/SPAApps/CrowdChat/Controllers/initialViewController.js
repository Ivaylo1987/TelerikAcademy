/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['viewLoader', 'jQuery'], function (viewLoader) {
    var viewURL = 'Views/initianlView.html';
    var userName;

    var loadView = function (container) {
        viewLoader.loadView(container, viewURL)
            .then(function () {
                $('submit-button').on('click', function () {
                    var input = $('name-input').val();
                    if (input) {
                        userName = input;
                    }
                    else {
                        alert('Please enter at least 2 letters!');
                    }

                })
            });
    };

    return {
        loadView: loadView
    }
})