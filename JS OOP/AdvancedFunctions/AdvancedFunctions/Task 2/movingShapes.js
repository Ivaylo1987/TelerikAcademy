var movingShapes = (function () {
    var interval = undefined;

    function move() {
        var rects = document.getElementsByClassName('rect');
        var circles = document.getElementsByClassName('circle');
        var position = 'down';
        var angle = 0.1;
        var radius = 100;
        var movingStep = 3;  // could be more or less
        
        for (var i = 0, len = rects.length; i < len; i++) {
            moveElementInRect(rects[i]);
        }
        for (var j = 0, length = circles.length; j < length; j++) {
            moveElementInCiricle(circles[j]);
        }

        // move in rect path using Offset to parent
        function moveElementInRect(rect) {
            var position = rect.getAttribute('wayToMove');
           
            if (parseInt(rect.offsetTop) < 200 && position == 'down') {
                rect.style.top = parseInt(rect.offsetTop) + movingStep + 'px';
                if (parseInt(rect.offsetTop) >= 200) {
                    rect.setAttribute('wayToMove', 'right');
                }
            }
            else if (parseInt(rect.offsetLeft) < 200 && position == 'right') {
                rect.style.left = parseInt(rect.offsetLeft) + movingStep + 'px';
                if (parseInt(rect.offsetLeft) >= 200) {
                    rect.setAttribute('wayToMove', 'up');
                }
            }
            else if (parseInt(rect.offsetTop) > 0 && position == 'up') {
                rect.style.top = parseInt(rect.offsetTop) - movingStep + 'px';
                if (parseInt(rect.offsetTop) <= 0) {
                    rect.setAttribute('wayToMove', 'left');
                }
            }
            else if (parseInt(rect.offsetLeft) > 0 && position == 'left') {
                rect.style.left = parseInt(rect.offsetLeft) - movingStep + 'px';
                if (parseInt(rect.offsetLeft) <= 0) {
                    rect.setAttribute('wayToMove', 'down');
                }
            }
        }

        // move in ellipese path
        function moveElementInCiricle(circle) {
            var angle = parseFloat(circle.getAttribute('angle'));
            circle.style.left = Math.cos(angle + 2 * Math.PI) * radius + "px";
            circle.style.top = Math.sin(angle + 2 * Math.PI) * radius  + "px";
            angle += 0.1;
            circle.setAttribute('angle', angle);
        }
    }

    // append new rect
    function addRectToHolder() {
        var holder = document.getElementById('holderForRect');
        var div = document.createElement('div');
        div.style.backgroundColor = generateRandomColor();
        div.style.color = generateRandomColor();
        div.style.borderColor = generateRandomColor();
        div.innerHTML = 'DIV';
        div.className = 'rect';
        div.setAttribute('wayToMove', 'down');

        holder.appendChild(div);
    }

    // append new circle
    function addCircleToHolder() {
        var holder = document.getElementById('holderForCircle');
        var div = document.createElement('div');
        div.style.backgroundColor = generateRandomColor();
        div.style.color = generateRandomColor();
        div.style.borderColor = generateRandomColor();
        div.innerHTML = 'DIV';
        div.className = 'circle';
        div.setAttribute('angle', '0.1');
        div.style.top = '0px';
        div.style.left = '100px';

        holder.appendChild(div);
    }

    function generateRandomColor() {
        var red = (Math.random() * 256) | 0;
        var green = (Math.random() * 256) | 0;
        var blue = (Math.random() * 256) | 0;

        return "rgb(" + red + "," + green + "," + blue + ")";
    }

    // add a shape
    function add(shapeName) {
        switch (shapeName) {
            case 'rect': addRectToHolder(); break;
            case 'ellipse': addCircleToHolder(); break;
            default: alert('Invalid Element'); break;

        }
    }

    // mode all shapes
    var moveElements = function () {
        if (interval) {
            clearInterval(interval);
            interval = undefined;
        }
        else { 
            interval = setInterval(move, 100);
        }
    }

    // module returns the above two functions
    return {
        add: add,
        move: moveElements
    }
}());