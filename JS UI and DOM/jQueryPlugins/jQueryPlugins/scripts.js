/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQueryPlugins\jQueryPlugins\libs/_reference.js" />
$(function () {

    $.fn.dropDownList = function () {
        var classOfgenerated = this.selector.substr(1, this.selector.length - 1) + '-list-container';
        var wrapper = $('<div />').addClass(classOfgenerated);
        var ul = $('<ul />').addClass(classOfgenerated);
        var li;


        if (true) {

        }

        this.children().each(function () {
            li = $('<li />');
            if (this.selected) {
                li.addClass('selected');
            }

            li.html(this.innerHTML);
            li.addClass(classOfgenerated);
            li.attr('data-values', this.value);
            ul.append(li);
        });

        this.hide();
        $('body').append(wrapper.append(ul))
        var clickBlick = $('.' + classOfgenerated);

        // Makes list selectable
        clickBlick.on('click', 'li', function () {
            $clicked = $(this);
            $clicked.parent().find('.selected').removeClass('selected');
            $clicked.addClass('selected');
        })
    }

    $('#generateList').on('click', function () {
        $('#dropdown').dropDownList();
    });
})