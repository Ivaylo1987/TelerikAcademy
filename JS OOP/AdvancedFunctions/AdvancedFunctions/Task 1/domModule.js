var domModule = (function () {
    'use strict';

    function appendChild(element, selector) {
        var parent = document.querySelector(selector);
        parent.appendChild(element);
    }

    function removeChild(parent, selector) {
        var parent = document.querySelector(parent);
        var child = parent.querySelector(selector);
        parent.removeChild(child);
    }

    function addHandler(selector, event, callBack) {
        var element = document.querySelector(selector);
        element.addEventListener(event, callBack);
    }

    function appendToBuffer() {
        var buffer = {},
        bufferSize = 100;

        return function append(selector, elementToAdd) {
            var parent, i, dFragment;

            parent = document.querySelector(selector);

            if (buffer[selector]) {
                buffer[selector].push(elementToAdd);

                if (buffer[selector].length === bufferSize) {
                    dFragment = document.createDocumentFragment();

                    for (i = 0; i < bufferSize; i++) {
                        dFragment.appendChild(buffer[selector][i]);
                    }

                    parent.appendChild(dFragment);
                    buffer[selector] = [];
                }
            }
            else {
                buffer[selector] = [];
            }
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer()
    };
}());