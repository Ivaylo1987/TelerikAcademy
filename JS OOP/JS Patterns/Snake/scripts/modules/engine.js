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
    currentDir = directions.right,
    snake = new Snake(),
    food = new Item(),
    score = 0,
    isGameActive = true;

    var addElementToHead = function () {
        var lastItemIndex = snake.body.length - 1;
        var newElementX = snake.body[lastItemIndex].x + currentDir.x;
        var newElementY = snake.body[lastItemIndex].y + currentDir.y;
        var newElement = new Item(newElementX, newElementY);

        // add new elements as snake head
        snake.body.push(newElement);
    }

    var removeLastSnakeElement = function () {
        // remove snake tail
        snake.body.shift();

    }

    var updateSnake = function () {
        addElementToHead();
        removeLastSnakeElement();
    }

    var updateSnakeAndFood = function () {
        var lastItemIndex = snake.body.length - 1;
        var snakeHead = snake.body[lastItemIndex];

        // if collision restart, else continue with game
        if (snakeHead.x >= canvas.width / snakeHead.size ||
                snakeHead.y >= canvas.height / snakeHead.size ||
                snakeHead.x < 0 ||
                snakeHead.y < 0 ||
                snakeHasHitBody(snakeHead.x, snakeHead.y, snake.body)) {
            isGameActive = false;
            gameLoop();
        }
        else {
            if (snakeHead.x === food.x && snakeHead.y === food.y) {
                addElementToHead();
                score += 10;
                food = new Item();
            }
            else {
                updateSnake();
            }
        }
    }

    var snakeHasHitBody = function (x, y, array) {
        for (var i = 0; i < array.length - 1; i++) {
            if (array[i].x == x && array[i].y == y) {
                return true;
            }
        }

        return false;
    }

    var drawSnake = function () {
        for (var i = 0; i < snake.body.length; i++) {
            if (i === snake.body.length - 1) {
                // last element in the body array is snake head
                canvas.drawRect(snake.body[i].x, snake.body[i].y, '#F00', snake.body[i].size)
            }
            else {
                canvas.drawRect(snake.body[i].x, snake.body[i].y, '#00F', snake.body[i].size)
            }
        }
    }

    var drawFood = function () {
        canvas.drawRect(food.x, food.y, 'yellow', food.size);
    }

    var gameLoop = function () {
        var loop;
        currentDir = directions.right;
        snake = new Snake();
        food = new Item();
        score = 0;

        if (isGameActive) {
            loop = setInterval(engine, 100);
        }
        else {
            clearInterval(loop);
        }
    }

    var engine = function () {
        canvas.clearCanvas();
        updateSnakeAndFood();
        drawFood();
        drawSnake();
        canvas.showScore(score);

        document.addEventListener('keydown', function (e) {
            var keyPressed = e.keyCode;

            if (keyPressed == 37 && currentDir != directions.right) {
                currentDir = directions.left;
            } else if (keyPressed == 38 && currentDir != directions.down) {
                currentDir = directions.up;
            } else if (keyPressed == 39 && currentDir != directions.left) {
                currentDir = directions.right;
            } else if (keyPressed == 40 && currentDir != directions.up) {
                currentDir = directions.down;
            }
        })
    }

    return gameLoop;
})