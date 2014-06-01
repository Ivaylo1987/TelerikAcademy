window.onload = function () {
    var canvas = document.getElementById('my-canvas');
    canvas.style.border = "3px solid black";
    var ctx = canvas.getContext('2d');
    ctx.fillStyle = "#90cad7";
    ctx.strokeStyle = "#22545f";
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

    function endDrawCommandsNoFill() {
        ctx.stroke();
        ctx.restore();
    }

    function drawWheels() {
        var y = 220;

        function drawWheel(x) {
            beginDrawCommands();
            ctx.arc(x, y, 60, 0, getRadian(360));
            endDrawCommands();
        }

        drawWheel(100);
        drawWheel(350);
    }

    function drawFrame() {
        var x = 170,
            y = 150;

        beginDrawCommands();
        ctx.moveTo(x, y);
        ctx.lineTo(x - 70, y + 70);
        ctx.lineTo(x + 50, y + 67);
        ctx.lineTo(x + 150, y);
        ctx.closePath();
        endDrawCommandsNoFill();
    }

    function drawPedals() {
        var x = 220,
            y = 215;

        beginDrawCommands();
        ctx.arc(x, y, 15, 0, getRadian(360));
        endDrawCommandsNoFill();

        beginDrawCommands();
        ctx.moveTo(x - 25, y - 25);
        ctx.lineTo(x - 10, y - 10);
        endDrawCommandsNoFill();

        beginDrawCommands();
        ctx.moveTo(x + 25, y + 25);
        ctx.lineTo(x + 10, y + 10);
        endDrawCommandsNoFill();

    }

    function drawSeat() {
        var x = 125,
            y = 118;

        beginDrawCommands();
        ctx.moveTo(x, y);
        ctx.lineTo(x + 50, y);
        ctx.stroke();
        ctx.restore();

        beginDrawCommands();
        ctx.moveTo(x + 25, y);
        ctx.lineTo(x + 95, y + 100);
        endDrawCommandsNoFill();
    }

    function drawStearing() {
        var x = 260,
            y = 118;

        beginDrawCommands();
        ctx.moveTo(x, y);
        ctx.lineTo(x + 50, y - 20);
        ctx.lineTo(x + 80, y - 60);
        endDrawCommandsNoFill();

        beginDrawCommands();
        ctx.moveTo(x + 50, y - 20);
        ctx.lineTo(x + 90, y + 110);
        endDrawCommandsNoFill();
    }

    function drawBike() {
        drawWheels();
        drawFrame();
        drawPedals();
        drawSeat();
        drawStearing();
    }

    drawBike();
}