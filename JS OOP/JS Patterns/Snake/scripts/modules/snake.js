/// <reference path="../_reference.js" />
define(['item'], function (Item) {
    var Snake = (function () {

        var initialBodyCount = 5;
        var bodyPartSize = 10;

        function Snake() {
            this.body = [];
            for (var i = 0; i < initialBodyCount; i++) {
                this.body.push(new Item(i, 10, bodyPartSize));
            }
        }

        return Snake;
    }())

    return Snake;
})