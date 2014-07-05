/// <reference path="../_reference.js" />
define(['point'], function (Point) {
    var Item = (function () {

        var getRandomCoords = function (size) {
            var coords = {};

            coords.x = Math.round(Math.random() * (canvas.width - size));
            coords.y = Math.round(Math.random() * (canvas.height - size));

            return coords;
        }

        var Item = function Item(x, y, size) {
            this.size = size || 10;
            var random = getRandomCoords(this.size);
            this.x = x || random.x;
            this.y = y || random.y;
        }

        Item.prototype = new Point()
        Item.prototype.constructor = Item;

       return Item;
    }())

    return Item;
})