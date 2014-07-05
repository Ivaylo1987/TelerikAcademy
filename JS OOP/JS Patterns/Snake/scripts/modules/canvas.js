/// <reference path="../libs/require.js" />
define(function () {

    var canvas = (function () {
        var mayCanvas = document.getElementById('canvas'),
        ctx = mayCanvas.getContext('2d'),
        CANVAS_SIZE = 500;
        width = CANVAS_SIZE,
        height = CANVAS_SIZE;

        function drawRect(x, y, fillStyle, rectSize) {
            ctx.beginPath();
            ctx.lineWidth = 1;
            ctx.fillStyle = fillStyle;
            ctx.strokeStyle = "black";

            ctx.fillRect(x, y, rectSize, rectSize);
            ctx.strokeRect(x, y, rectSize, rectSize);
            ctx.closePath()
        }

        function clearCanvas() {
            ctx.beginPath();
            ctx.fillStyle = "#FFF";
            ctx.fillRect(0, 0, width, height);
            ctx.strokeStyle = "black";
            ctx.strokeRect(0, 0, width, height);
            ctx.closePath()
        }

        function showScore(score) {
            var text = "Score: " + score;
            ctx.fillText(text, 10, height - 10);
        }

        return {
            drawRect: drawRect,
            clearCanvas: clearCanvas,
            showScore: showScore,
            width: width,
            height: height
        }
    }())
    

    return canvas;
})