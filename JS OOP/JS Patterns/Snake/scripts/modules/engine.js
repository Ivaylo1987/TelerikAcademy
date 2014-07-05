/// <reference path="../_reference.js" />
define(['canvas', 'item', 'snake'], function (canvas, Item, Snake) {
    var directions = {
        right: {
            x: 1,
            y: 0
        },
        left: {
            x: -1,
            y: 0
        },
        up: {
            x: 0,
            y: -1
        },
        down: {
            x: 0,
            y: 1
        }
    },
    snake = new Snake(),
    currentDir = directions.right;

    var updateSnake = function () {
        for (var i = 0; i < snake.body.length; i++) {
            snake.body[i].x += currentDir.x;
            snake.body[i].y += currentDir.y;
        }
    }

    var drawSnake = function () {
        for (var i = 0; i < snake.body.length; i++) {
            if (i !== snake.body.length - 1) {
                canvas.drawRect(snake.body[i].x, snake.body[i].y, '#00F', snake.body[i].size)
            }
            else {
                canvas.drawRect(snake.body[i].x, snake.body[i].y, '#F00', snake.body[i].size)
            }
        }
    }

    canvas.clearCanvas();
    updateSnake();
    drawSnake();

    document.addEventListener('keydown', function (e) {
        var keyPressed = e.which;

        if (keyPressed == "37" && currentDir != directions.right) {
            currentDir = directions.left;
        } else if (keyPressed == "38" && currentDir != directions.down) {
            currentDir = directions.up;
        } else if (keyPressed == "39" && currentDir != directions.left) {
            currentDir = directions.right;
        } else if (keyPressed == "40" && currentDir != directions.up) {
            currentDir = directions.down;
        }
    })
})