/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\HTMLTemplates-HandleBarsJS\HTMLTemplates-HandleBarsJS\libs/handlebars-v1.3.0.js" />
/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\HTMLTemplates-HandleBarsJS\HTMLTemplates-HandleBarsJS\libs/jquery-2.1.1.min.js" />
$(function () {
    $.fn.listview = function (collection) {
        var templateSelector = this.attr('data-template');
        var template = $('#' + templateSelector);
        var compiledTemplate = Handlebars.compile(template.html());
        var that = this;

        $.each(collection, function (index, value) {
            var result = compiledTemplate(value);
            that.append(result);
        });
    }

    var books = [{
            id: 0,
            title: 'Harry Potter'
        }, {
            id: 1,
            title: 'Ten Little Indians'
        }, {
            id: 2,
            title: 'Dorian Grey'
        }
    ]

    var students = [
        pesho = {
            name: 'Pesho',
            number: 1,
            mark: '3'
        },
        gosho = {
            name: 'Bar',
            number: 13,
            mark: '4'
        },
        penka = {
            name: 'Penka',
            number: 10,
            mark: '5'
        },
        maria = {
            name: 'Maria',
            number: 7,
            mark: '6'
        },
    ]

    $('#books-list').listview(books);
    $('#students-table').listview(students);
})