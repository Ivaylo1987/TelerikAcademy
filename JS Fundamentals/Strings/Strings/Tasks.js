(function () {
    //task 1
    function reverse(input) {
        var result = input.split('').reverse().join('');
        return result;
    }

    jsConsole.writeLine(reverse('String'));

    //Task 2
    function areBracketsCorrect(input) {
        var count = 0;

        for (var i = 0; i < input.length; i++) {
            if (input[i] === '(') {
                count++;
            }
            else if (input[i] === ')') {
                count--;
            }
        }

        return count == 0;
    }

    jsConsole.writeLine(areBracketsCorrect('((a+b)/5-d)..as ( 2 + 1(;')); //false
    jsConsole.writeLine(areBracketsCorrect('((a+b)/5-d)..as ( 2 + 1);')); //true

    //task 3
    function stringOccurances(input, key) {
        input = input.toLowerCase();
        key - key.toLowerCase();
        var count = 0;
        var index = -1;

        while ((index = input.indexOf(key, index + 1)) != -1) {
            count++;
        }

        return count;
    }

    var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    var key = 'in';

    
    jsConsole.writeLine(stringOccurances(text, key)); //9
})()