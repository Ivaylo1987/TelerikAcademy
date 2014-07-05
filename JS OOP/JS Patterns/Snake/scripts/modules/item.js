/// <reference path="../_reference.js" />
define(['point'], function (Point) {
    var Item = (function () {

        var Item = function Item(size, x, y) {
            this.size = size || 10;
            this.x = x || this.x;
            this.y = y || this.y;
        }

        Item.prototype = new Point()
        Item.prototype.constructor = Item;

       return Item;
    }())

    return Item;
})