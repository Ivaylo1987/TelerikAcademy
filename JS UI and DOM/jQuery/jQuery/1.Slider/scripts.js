/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQuery\jQuery\_reference.js" />
$(function () {
    var $container = $('#container'),
        $nextButton = $('#next'),
        $prevoiusButton = $('#previous');

    $container.children().first().addClass('current');

    $nextButton.on('click', function () {
        var current = $container.find('.current');
        current.removeClass('current');

        if (current.next().length === 0) {
            $container.children().first().addClass('current');
        }
        else {
            current.next().addClass('current');
        }
    })

    $prevoiusButton.on('click', function () {
        var current = $container.find('.current');
        current.removeClass('current');

        if (current.prev().length === 0) {
            $container.children().last().addClass('current');
        }
        else {
            current.prev().addClass('current');
        }
    })

    // slef sliding ever 4 seconds
    function moveimage() {
        $nextButton.click();
        setTimeout(moveimage, 4000);
    }
    moveimage();
})