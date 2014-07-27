/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['viewLoader', 'jQuery'], function (viewLoader) {
    var viewURL = 'Views/initianlView.html';

    var run = function (container) {
        viewLoader.loadView(viewURL)
            .then(function (data) {
                $(container).html(data);

                $('#submit-button').on('click', function () {
                    var input = $('#name-input').val();
                    if (input) {
                        window.location.hash = '#/chatRoom';
                        sessionStorage.setItem('username', input);
                    }
                    else {
                        alert('Please enter at least 2 letters!');
                    }

                })
            });
    };

    return {
        run: run
    }
})