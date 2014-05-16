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

    //Task 3
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

    //Task 4

    function changeInAllReagion(input) {
        input = input.replace(/<upcase>(.+?)<\/upcase>/gi, function (match, p1) { return p1.toUpperCase() });
        input = input.replace(/<lowcase>(.+?)<\/lowcase>/gi, function (match, p1) { return p1.toLowerCase() });
        input = input.replace(/<mixcase>(.+?)<\/mixcase>/gi,
            function (match, p1) {
                var chanse;
                var result = '';

                for (var i = 0; i < p1.length; i++) {
                    chanse = Math.floor(Math.random() * 2);

                    if (chanse) {
                        result += p1[i].toLowerCase();
                    }
                    else {
                        result += p1[i].toUpperCase();
                    }

                }

                return result;
            });

        return input;
    }

    var txt = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything<\/lowcase> else.';
    jsConsole.writeLine(changeInAllReagion(txt));

    //Task 5
    function replaceSpace(input) {
        return input.replace(/ /g, 'nbsp;');
    }

    var spaces = 'text    with spaces';
    jsConsole.writeLine(replaceSpace(spaces));

    //Task 6

    function removeTags(input) {
        return input.replace(/<[^>]+>/gi, '');
    }

    var textTags = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
    jsConsole.writeLine(removeTags(textTagss));

    // Task 7
    function jsonURL(input) {
        var parseResult = input.match(/(.+?):\/\/(.+?)(\/.+)/i);

        return {
            protocol: parseResult[1],
            server: parseResult[2],
            resourse: parseResult[3]
        }
    }

    var url = 'http://www.supprot.devbg.org/forum/index.php';
    jsConsole.writeLine(JSON.stringify(jsonURL(url)));
})()