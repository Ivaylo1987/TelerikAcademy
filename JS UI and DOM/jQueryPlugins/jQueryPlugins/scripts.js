/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQueryPlugins\jQueryPlugins\libs/_reference.js" />
$(function () {

    $.fn.dropDownList = function () {
        var selector = this.selector;
        var wrapper = $('<div />').addClass(selector + '-list-container');

        this.hide();
        $('body').append(wrapper)
    }

    $('#dropdown').dropDownList();
})