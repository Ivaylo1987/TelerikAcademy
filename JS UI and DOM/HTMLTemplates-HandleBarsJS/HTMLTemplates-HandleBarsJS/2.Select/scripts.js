/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS UI and DOM\HTMLTemplates-HandleBarsJS\HTMLTemplates-HandleBarsJS\libs/_reference.js" />

var items = [{
    value: 1,
    text: 'One'
}, {
    value: 2,
    text: 'Two'
}, {
    value: 3,
    text: 'Three'
}, {
    value: 4,
    text: 'Four'
}, {
    value: 5,
    text: 'five'
}, {
    value: 6,
    text: 'Six'
}];

var teplateHTML = document.getElementById('template').innerHTML;
var templateCompiled = Handlebars.compile(teplateHTML);
var target = document.getElementById('root');

target.innerHTML += templateCompiled({
    options: items
});