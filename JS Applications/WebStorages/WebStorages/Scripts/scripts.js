//Sorry for the ugly interface but I didn't have the time to make a better one.
$(function () {
    'use strict';
    var wrapper = $('#wrapper');
    var button = $('<button />').html('Guess!');
    var input = $('<input />').addClass('input').attr('type', 'text').attr('placeholder', '*Put Your Guess Here*').attr('pattern', '[0-9]{4}');
    var playerGuesses = $('<ol />').addClass('guesses');
    var secretNumber = [];
    var player = {
        name: 'player defaut',
        sheets: 0,
        rams: 0,
        attempts: 0
    }

    // main game logic
    function validateGuess(guess) {
        var guess = input.val();
        var guessNumber = guess.split('').map(Number);
        var guessItem = $('<li>').addClass('guess-item');
        var indexOfDigit;
        player.rams = 0;
        player.sheets = 0;

        for (var i = 0; i < guessNumber.length; i++) {
            indexOfDigit = secretNumber.indexOf(guessNumber[i]);

            if (indexOfDigit === i) {
                player.rams++;
            }
            else if (indexOfDigit !== -1) {
                player.sheets++;
            }
        }

        if (player.rams === 4) {
            helper.saveResult(wrapper, player, secretNumber);
        }

        guessItem.append(guess).append(' - Rams: ' + player.rams + ' Sheeps: ' + player.sheets);
        playerGuesses.append(guessItem)

        player.attempts++;
        input.val('');
    }

    wrapper.append(input).append(button).append(playerGuesses);
    secretNumber = helper.generateSecretNumber();
    button.on('click', validateGuess);

    // a cheat ;)
    console.log(secretNumber);
})