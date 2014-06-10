(function () {
    var Divs = document.getElementsByClassName("nestedDiv");
    var angle = 0;
    var radius = 100;
    (function move() {

        for (var i = 0; i < 5; i++) {
            Divs[i].style.left = Math.cos(angle + 2 * Math.PI / Divs.length * i) / radius * 10000 + "px";
            Divs[i].style.top = Math.sin(angle + 2 * Math.PI / Divs.length * i) / radius * 10000 + "px";
        }

        angle += 0.1;
        setTimeout(move, 100);
    })()
})()