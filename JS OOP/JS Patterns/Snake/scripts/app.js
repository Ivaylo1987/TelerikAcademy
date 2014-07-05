/// <reference path="_reference.js" />
(function () {
    require.config({
        paths:{
            'canvas': 'modules/canvas',
            'point': 'modules/point',
            'item': 'modules/item',
            'snake': 'modules/snake',
            }
    })

    require(['canvas', 'snake'], function (canvas) {
        canvas.clearCanvas();

        var snake = new Snake();
        for (var i = 0; i < snake.body.length; i++) {
            canvas.drawRect(snake.body[i].x, snake.body[i].y, '#F00', snake.body[i].size)
        }
    })
}())