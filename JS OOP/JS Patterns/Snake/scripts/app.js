/// <reference path="_reference.js" />
(function () {
    require.config({
        paths:{
            'canvas': 'modules/canvas',
            'point': 'modules/point',
            'item': 'modules/item',
            'snake': 'modules/snake',
            'engine': 'modules/engine'
            }
    })

    require(['canvas', 'snake', 'engine'], function (canvas, Snake, engine) {
        
        setInterval(engine, 200);
    })
}())