/// <reference path="_references.js" />
helper = (function() {
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

    // builds the form for the player's Name
    function buildDetailsPopUp(wrapper, secretNumber, player) {
        var $detailsPanel = $('<div>').addClass('details-panel');
        var $input = $('<input />').attr('id', 'name-input');
        var $label = $('<label />').html('Your Name: ').attr('for', 'name-input');
        var $submitBtn = $('<button>').html('Submit').addClass('submit-name');
        var $congrats = $('<p />').html('The Secret Number is: ' + secretNumber.join('') + ' !' + 'Congratulations, you guessed it in ' + player.attempts + ' attempts!');

        $detailsPanel.append($congrats).append($label).append($input).append($submitBtn).appendTo(wrapper);
    }

    function buildHighScoreList(wrapper) {
        var highScorelist = $('<ol />').addClass('high-score-list');
        var arrList = [];

        for (var key in localStorage) {
            var item = localStorage.getObject(key);
            if (item) {
                arrList.push(item);
            }
        }

        arrList.sort(function (first, next) {
            return first.attempts - next.attempts;
        })

        arrList.forEach(function (item) {
            var listItem = $('<li />').append(item.name + ' - ' + item.attempts + ' attempts');
            highScorelist.append(listItem);
        })

        wrapper.append(highScorelist);
    }

    // uses localstorage to save the result
    function saveResult(wrapper, player, secretNumber) {
        buildDetailsPopUp(wrapper, secretNumber, player);

        $('.submit-name').on('click', function () {
            player.name = $('#name-input').val();
            localStorage.setObject(player.name, player);
            buildHighScoreList(wrapper);

            $('.details-panel').append('<p>' + 'Thank you!' + '</p>');
        })

    }

    return {
        saveResult: saveResult,
        generateSecretNumber: generateSecretNumber
    }
}())