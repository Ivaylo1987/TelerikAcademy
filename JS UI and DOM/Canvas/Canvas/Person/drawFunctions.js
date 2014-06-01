window.onload = function () {

    var canvas = document.getElementById('my-canvas');
    canvas.style.border = "3px solid black";
    var ctx = canvas.getContext('2d');

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

    function drawHat() {
        var projectX = 130;
        ctx.fillStyle = "#396693";
        ctx.lineWidth = 2;
        ctx.strokeStyle = "black";

        function drawTop() {
            var x = 105 + projectX,
                y = 210;

            beginDrawCommands();
            ctx.scale(1, 0.4);
            ctx.arc(x, y, 40, 0, getRadian(360));
            endDrawCommands();
        }

        function drawBody() {
            var x = 65 + projectX,
                y = 85;

            beginDrawCommands();
            ctx.moveTo(x, y);
            ctx.lineTo(x, y + 70);
            ctx.bezierCurveTo(x + 10, y + 85, x + 70, y + 85, x + 80, y + 70);
            ctx.lineTo(x + 80, y);
            endDrawCommands();
        }

        function drawBottom() {
            var x = 100 + projectX,
                y = 800;

            beginDrawCommands();
            ctx.scale(1, 0.2);
            ctx.arc(x, y, 80, 0, getRadian(360));
            endDrawCommands();
        }

        drawBottom();
        drawBody();
        drawTop();
    }

    function drawHead() {
        var projectX = 133;
        ctx.fillStyle = "#90cad7";
        ctx.strokeStyle = "#22545f";
        ctx.lineWidth = 3;

        function drawFace() {
            var x = 100 + projectX,
                y = 220;

            beginDrawCommands();
            ctx.arc(x, y, 70, 0, getRadian(360));
            endDrawCommands();
        }

        function drawNose() {
            var x = 85 + projectX,
                y = 200;

            beginDrawCommands();
            ctx.moveTo(x, y);
            ctx.lineTo(x - 15, y + 30);
            ctx.lineTo(x, y + 30);
            endDrawCommands();

        }

        function drawMouth() {
            var x = 120 + projectX,
                y = 560;

            beginDrawCommands();
            ctx.rotate(getRadian(8));
            ctx.scale(1, 0.4);
            ctx.arc(x, y, 25, 0, getRadian(360));
            endDrawCommands();
        }

        function drawEyes() {
            var y = 285,
                yScale = 0.7;

            function drawLeftEye() {
                var x = 55 + projectX;

                beginDrawCommands();
                ctx.scale(1, yScale);
                ctx.arc(x, y, 10, 0, getRadian(360));
                endDrawCommands();
            }

            function drawRightEye() {
                var x = 110 + projectX;

                beginDrawCommands();
                ctx.scale(1, yScale);
                ctx.arc(x, y, 10, 0, getRadian(360));
                endDrawCommands();
            }

            function drawLeftRetina() {
                var x = 238 + projectX,
                    y = 199;

                beginDrawCommands();
                ctx.fillStyle = "#22545f";
                ctx.scale(0.5, 1);
                ctx.arc(x, y, 5, 0, getRadian(360));
                endDrawCommands();
            }

            function drawRightRetina() {
                var x = 348 + projectX,
                    y = 199;

                beginDrawCommands();
                ctx.fillStyle = "#22545f";
                ctx.scale(0.5, 1);
                ctx.arc(x, y, 5, 0, getRadian(360));
                endDrawCommands();
            }

            drawLeftEye();
            drawRightEye();
            drawLeftRetina();
            drawRightRetina();
        }

        drawFace();
        drawEyes();
        drawNose();
        drawMouth();
    }

    drawHead();
    drawHat();
}

