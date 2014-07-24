/// <reference path="_references.js" />
$(function () {
    'use strict';
    var wrapper = $('#wrapper');
    var button = $('<button />').html('Guess!');
    var input = $('<input />').addClass('input').attr('type', 'text').attr('pattern', '^[0-9]{4}$').attr('placeholder', '*Put Your Guess Here*');
    var secretNumber = [];
    var player = {
        name: 'player defaut',
        sheets: 0,
        rams: 0,
        attempts: 0
    }

    // extend Storage to store objects as strings
    Storage.prototype.setObject = function (objName, object) {
        objName = objName || 'default';
        object = object || {};
        this.setItem(objName, JSON.stringify(object));
    }

    // extend Storage to get object by its name
    Storage.prototype.getObject = function (objName) {
        objName = objName || '';
        return JSON.parse(this.getItem(objName));
    }

    function generateSecretNumber() {
        var secretNumber = [];
        var inProgress = true;
        var candidateDigit;

        while (inProgress) {
            candidateDigit = Math.floor(Math.random() * 10);
            if (candidateDigit === 0 && secretNumber.length === 0) {
                continue;
            }

            if (secretNumber.indexOf(candidateDigit) === -1) {
                secretNumber.push(candidateDigit);
            }

            if (secretNumber.length === 4) {
                inProgress = false;
            }
        }

        return secretNumber;
    }

    function buildDetailsPopUp() {
        var $resultPanel = $('<div>').addClass('result-panel');
        var $input = $('<input />').attr('id', 'name-input');
        var $label = $('<label />').html('Your Name: ').attr('for', 'name-input');
        var $submitBtn = $('<button>').html('Submit').addClass('submit-name');
        var $congrats = $('<p />').html('The Secret Number is: ' + secretNumber.join('') + ' !' + 'Congratulations, you it in ' + player.attempts + ' attempts!');

        $resultPanel.append($congrats).append($label).append($input).append($submitBtn).appendTo(wrapper);
    }

    function saveResult() {
        buildDetailsPopUp();

        $('.submit-name').on('click', function () {
            player.name = $('#name-input').val();
            localStorage.setObject(player.name, player);
            $('.result-panel').append('<p>' + 'Thank you!' + '</p>');
        })

    }

    function validateGuess(guess) {
        var guess = input.val();
        var guessNumber = guess.split('').map(Number);
        var indexOfDigit;
        player.rams = 0;
        player.sheets = 0;

        for (var i = 0; i < guessNumber.length; i++) {
            indexOfDigit = secretNumber.indexOf(guessNumber[i]);

            if (indexOfDigit === i) {
                player.rams++;
            }
            else if(indexOfDigit !== - 1){
                player.sheets++;
            }
        }

        if (player.rams === 4) {
            saveResult();
        }

        player.attempts++;
        input.val('');
        console.log(player);
    }

    wrapper.append(input).append(button);
    secretNumber = generateSecretNumber();
    button.on('click', validateGuess);

    console.log(secretNumber);
})