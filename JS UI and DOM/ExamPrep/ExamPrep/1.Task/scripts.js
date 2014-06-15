function createCalendar(selector, events) {
    var container = document.querySelector(selector);

    var dFragment = document.createDocumentFragment();
    var daysofWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

    for (var i = 0; i <= 30; i++) {
        var div = document.createElement('div');
        var strong = document.createElement('strong');
        strong.innerHTML += daysofWeek[i % daysofWeek.length] + ' ' + (i + 1) + ' June 2014';
        div.appendChild(strong);
        div.className += 'inner';
        dFragment.appendChild(div);
    }

    container.appendChild(dFragment);

    for (var i = 0; i < events.length; i++) {
        container.children[events[i].date].innerHTML += events[i].hour + ' ' + events[i].title;
    }

    var divs = document.querySelector()
}