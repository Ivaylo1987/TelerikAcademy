/// <reference path="../_reference.js" />
define(['item'], function () {
    var Snake = (function () {

        var initialBodyCount = 5;
        var bodyPartSize = 10;

        function Snake() {
            this.body = [];
            for (var i = 0; i < initialBodyCount; i++) {
                this.body.push(new Item(bodyPartSize, (100 + i * bodyPartSize), 250));
            }
        }

        return Snake;
    }())

    return Snake;
})