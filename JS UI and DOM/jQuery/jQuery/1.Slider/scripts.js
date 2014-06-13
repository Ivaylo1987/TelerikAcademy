/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQuery\jQuery\_reference.js" />
$(function () {
    var $container = $('#container');
    $container.children().first().addClass('current');

    var nextButton = $('#next');
    var prevoiusButton = $('#previous');

    nextButton.on('click', function () {
        var current = $container.find('.current');

        if (current.next().length === 0) {
            current.removeClass('current');
            $container.children().first().addClass('current');
        }
        else {
            current.removeClass('current').next().addClass('current');
        }
        
    })

    prevoiusButton.on('click', function () {
        $container.find('.current').removeClass('current').prev().addClass('current');
    })
})