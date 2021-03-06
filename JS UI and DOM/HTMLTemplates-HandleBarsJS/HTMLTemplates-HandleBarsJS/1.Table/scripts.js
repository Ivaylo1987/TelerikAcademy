﻿/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\HTMLTemplates-HandleBarsJS\HTMLTemplates-HandleBarsJS\libs/_reference.js" />
var schedule = [{
    title: 'Course introduction',
    firstDate: 'Wed 18:00, 28-May-2014',
    secondDate: 'Thu 14:00, 29-May-2014'
}, {
    title: 'Document Object Model',
    firstDate: 'Wed 18:00, 28-May-2014',
    secondDate: 'Thu 14:00, 29-May-2014'
}, {
    title: 'HTML5 Canvas',
    firstDate: 'Wed 18:00, 29-May-2014',
    secondDate: 'Thu 14:00, 30-May-2014'
}, {
    title: 'KineticJS Overview',
    firstDate: 'Wed 18:00, 29-May-2014',
    secondDate: 'Thu 14:00, 30-May-2014'
}, {
    title: 'SVG And RaphaelJS',
    firstDate: 'Wed 18:00, 04-Jun-2014',
    secondDate: 'Thu 14:00, 05-Jun-2014'
}, {
    title: 'Animations with Canvas and SVG',
    firstDate: 'Wed 18:00, 04-Jun-2014',
    secondDate: 'Thu 14:00, 05-Jun-2014'
}, {
    title: 'DOM Operations',
    firstDate: 'Wed 18:00, 05-Jun-2014',
    secondDate: 'Thu 14:00, 06-Jun-2014'
}, {
    title: 'Event Model',
    firstDate: 'Wed 18:00, 05-Jun-2014',
    secondDate: 'Thu 14:00, 06-Jun-2014'
}, {
    title: 'jQuery overview',
    firstDate: 'Wed 18:00, 11-Jun-2014',
    secondDate: 'Thu 14:00, 12-Jun-2014'
}, {
    title: 'HTML Templates',
    firstDate: 'Wed 18:00, 11-Jun-2014',
    secondDate: 'Thu 14:00, 12-Jun-2014'
}, {
    title: 'Exam Preparation',
    firstDate: 'Wed 18:00, 12-Jun-2014',
    secondDate: 'Thu 14:00, 13-Jun-2014'
}, {
    title: 'Exam',
    firstDate: 'Tue 10:00, 17-Jun-2014',
    secondDate: 'Thu 16:30, 17-Jun-2014'
}, {
    title: 'Teamwork defense',
    firstDate: 'Wed 10:00, 19-Jun-2014',
    secondDate: 'Thu 10:00, 19-Jun-2014'
}
]

var templateHTML = document.getElementById('template').innerHTML;
var compiledTemplate = Handlebars.compile(templateHTML);
var target = document.getElementById('root');

target.innerHTML += compiledTemplate({
    courses: schedule
});