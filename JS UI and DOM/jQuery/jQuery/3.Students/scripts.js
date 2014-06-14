/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\jQuery\jQuery\_reference.js" />
$(function () {
    var students = [
        pesho = {
            name: 'Pesho',
            lastname: 'Ivanov',
            grade: '3'
        },
        gosho = {
            name: 'Bar',
            lastname: 'Joro',
            grade: '4'
        },
        penka = {
            name: 'Penka',
            lastname: 'Stoyanova',
            grade: '5'
        },
        maria = {
            name: 'Maria',
            lastname: 'Hristova',
            grade: '6'
        },
        dinko = {
            name: 'Dinko',
            lastname: 'Bat Joro....!',
            grade: '6'
        }
    ],
    $wrapper = $('#wrapper'),
    table = $('<table />').addClass('table');
    $wrapper.append(table);

    students.forEach(function (element) {
        var student = element;
        var $Row = $('<tr />');
        $Row.append($('<td />').html(student.name));
        $Row.append($('<td />').html(student.lastname));
        $Row.append($('<td />').html(student.grade));
        table.append($Row);
    })
})