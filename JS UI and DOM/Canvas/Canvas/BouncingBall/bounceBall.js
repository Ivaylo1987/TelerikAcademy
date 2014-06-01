window.onload = function() {
    var canvas = document.getElementById('my-canvas');
    canvas.style.border = '5px solid #663300';
    canvas.style.borderStyle = 'ridge';
    var ctx = canvas.getContext('2d');
    ctx.fillStyle = 'green';

    var direction = {
        x: 1,
        y: 1
    }

    var position = {
        x: 10,
        y: 10
    }

    function drawBall() {
        if (position.x == 495) {
            direction.x *= -1;
        }
        if (position.x == 5) {
            direction.x *= -1;
        }
        if (position.y == 395) {
            direction.y *= -1;
        }
        if (position.y == 5) {
            direction.y *= -1;
        }

        ctx.clearRect(0, 0, canvas.width, canvas.height);
        ctx.beginPath();
        ctx.arc(position.x, position.y, 15, 0, 2 * Math.PI);
        ctx.fill();

        position.x += direction.x;
        position.y += direction.y;
    }

    setInterval(drawBall, 5);
}