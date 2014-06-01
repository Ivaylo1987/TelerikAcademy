window.onload = function () {

    var canvas = document.getElementById('my-canvas');
    canvas.style.border = "3px solid black";
    var ctx = canvas.getContext('2d');

    ctx.fillStyle = "#975b5b";
    ctx.strokeStyle = "#000";
    ctx.lineWidth = 2;

    function getRadian(degrees) {
        return degrees * Math.PI / 180;
    }

    function beginDrawCommands() {
        ctx.beginPath();
        ctx.save();
    }

    function endDrawCommands() {
        ctx.fill();
        ctx.stroke();
        ctx.restore();
    }

    function drawCircle(x, y, radius, start, end, clockwise, scalex, scaley) {
        beginDrawCommands()
        ctx.scale(scalex, scaley);
        ctx.beginPath();
        ctx.arc(x, y, radius, start, end, clockwise);
        endDrawCommands()
    }
    function drawRectangle(x, y, xlen, ylen) {
        ctx.beginPath();
        ctx.fillRect(x, y, xlen, ylen);
        ctx.strokeRect(x, y, xlen, ylen);
    }
    function doRotate(x, y, r) {
        ctx.translate(x, y);
        ctx.rotate(r);
        ctx.translate(-x, -y);
    };


    function drawHouse() {
        // Roof
        beginDrawCommands()
        doRotate(150, 0, getRadian(45));
        drawRectangle(150, 0, 196, 196);
        endDrawCommands()

        // Chimney
        drawRectangle(210, 30, 32, 85);
        ctx.beginPath();
        ctx.fillRect(211, 30, 30, 90);
        drawCircle(226, 75, 16, 0, getRadian(360), false, 1, 0.4);

        // House Body
        drawRectangle(10, 141, 280, 210);

        // Door
        drawRectangle(40, 275, 80, 76);

        drawCircle(80, 550, 40, getRadian(180), getRadian(360), false, 1, 0.5);
        ctx.save();
        ctx.scale(1, 0.5);
        ctx.beginPath();
        ctx.arc(80, 555, 38.5, 0, getRadian(360));
        ctx.fill();
        ctx.restore();
        ctx.beginPath();
        ctx.moveTo(80, 351);
        ctx.lineTo(80, 254);
        ctx.stroke();

        drawCircle(65, 323, 5, 0, getRadian(360), true, 1, 1);
        drawCircle(ctx, 95, 323, 5, 0, getRadian(360), true, 1, 1);

        //Windows
        ctx.strokeStyle = "#975B5B";
        ctx.fillStyle = "#000";
        drawRectangle(30, 165, 50, 35);
        drawRectangle(82, 165, 50, 35);
        drawRectangle(168, 165, 50, 35);
        drawRectangle(220, 165, 50, 35);
        drawRectangle(30, 202, 50, 35);
        drawRectangle(82, 202, 50, 35);
        drawRectangle(168, 202, 50, 35);
        drawRectangle(220, 202, 50, 35);
        drawRectangle(168, 260, 50, 35);
        drawRectangle(220, 260, 50, 35);
        drawRectangle(168, 297, 50, 35);
        drawRectangle(220, 297, 50, 35);
    }

    drawHouse();
}
