/// <reference path="../_reference.js" />
define(['canvas'], function (canvas) {
    var Point = (function () {
        var getRandomCoords = function () {
            var result = {};
            result.x = Math.round(Math.random() * (canvas.width - 10));
            result.y = Math.round(Math.random() * (canvas.height - 10));

            return result;
        }

        var Point = function () {
            var coords = getRandomCoords();
            this.x = coords.x;
            this.y = coords.y;
        }

        return Point
    }())

    return Point;
})