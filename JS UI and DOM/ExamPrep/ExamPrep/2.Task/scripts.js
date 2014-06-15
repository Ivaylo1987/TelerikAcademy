/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\ExamPrep\ExamPrep\libs/_reference.js" />
$.fn.tabs = function () {
    this.addClass('tabs-container');
    this.find('.tab-item-content').hide();

    this.find('.tab-item').on('click', function () {
        var clicked = $(this);
        var current = clicked.parent().find('.current');

        current.find('.tab-item-content').hide();
        current.removeClass('current');

        clicked.addClass('current');
        clicked.find('.tab-item-content').show();
    });
};