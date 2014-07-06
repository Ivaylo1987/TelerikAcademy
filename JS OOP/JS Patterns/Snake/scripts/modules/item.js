/// <reference path="../_reference.js" />
define(['point'], function (Point) {
    var Item = (function () {

        var getRandomCoord = function (size) {
            // devided by the size of the item for easy drwaing in canvas see canvas.drawRect;
            return Math.round(Math.random() * (canvas.width - size) / size);;
        }

        var Item = function Item(x, y, size) {
            var coordX,
                coodrY;
            this.size = size || 10;

            if (arguments.length > 1) {
                this.x = x 
                this.y = y 
            }
            else {
                coordX = getRandomCoord(this.size);
                this.x = coordX;

                coodrY = getRandomCoord(this.size);
                this.y = coodrY;
            }
            
        }

       return Item;
    }())

    return Item;
})