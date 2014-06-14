/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQuery\jQuery\_reference.js" />
$(function () {
    var $container = $('#container'),
        $nextButton = $('#next'),
        $prevoiusButton = $('#previous'),
        $slideShowButton = $('#slideShow'),
        isOnSlideShow = false,
        slideShowHadler;

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
    
    $slideShowButton.on('click', function () {
        isOnSlideShow = !isOnSlideShow;

        if (isOnSlideShow) {
            function moveImage() {
                $nextButton.click();
            }
            slideShowHadler = setInterval(moveImage, 2000)
        }
        else {
            clearInterval(slideShowHadler);
        }
    })
})