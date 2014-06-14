/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQuery\jQuery\_reference.js" />
$(function () {
    var colorPicker = $('input');
    colorPicker.on('change', function () {
        color = colorPicker.val();
        $('body').css('background', color)
    })
})