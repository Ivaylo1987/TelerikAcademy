//Task 1
(function task1() {
    var arr = [];
    arr.length = 20;
    for (var i = 0; i < arr.length; i++) {
        arr[i] = i * 5;
    }
    jsConsole.writeLine(arr.join(', '));
})();

//Task 2
(function task2() {
    var charArr1 = 'abcde';
    var charArr2 = 'abcdz';
    var minLength = charArr1.length;

    if (minLength > charArr2.length) {
        minLength = charArr2.length;
    }

    for (var i = 0; i < minLength; i++) {

        if (charArr1[i] > charArr2[i]) {
            jsConsole.writeLine(charArr1 + ' is lexicographically after ' + charArr2 + ' at char: ' + i);
            break;
        }
        else if (charArr1[i] < charArr2[i]) {
            jsConsole.writeLine(charArr1 + ' is lexicographically before ' + charArr2 + ' at char: ' + i);
            break;
        }
        else if (i == minLength - 1) {
            jsConsole.writeLine(charArr1 + ' and ' + charArr2 + ' are lexicographically equal.');
        }
    }
})();

//Task 3
(function Task3() {
    var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1];
    var maxCount = 1;
    var count = 1;
    var element;

    for (var i = 0; i < arr.length - 1; i++) {

        if (arr[i] === arr[i + 1]) {
            count++;

            if ((i === arr.length - 2) && (count > maxCount)) {
                maxCount = count;
                element = arr[i];
            }
        }
        else {
            if (count > maxCount) {
                maxCount = count;
            }
            element = arr[i];
            count = 1;
        }
    }
    jsConsole.writeLine(element + ' -> ' + maxCount + ' times');
})();

//Task 4
(function Task4() {
    var arr = [3, 2, 3, 4, 2, 2, 4, 5, 6, 10, 17];
    var maxCount = 1;
    var count = 1;
    var tempResult = arr[0].toString();
    var result = '';

    for (var i = 0; i < arr.length - 1; i++) {

        if (arr[i] < arr[i + 1]) {
            count++;
            tempResult = tempResult + ' ' + arr[i + 1];

            if ((i === arr.length - 2) && (count > maxCount)) {
                maxCount = count;
                result = tempResult;
            }
        }
        else {
            if (count > maxCount) {
                maxCount = count;
                result = tempResult;
            }
            count = 1;
            tempResult = arr[i + 1].toString();
        }
    }
    jsConsole.writeLine(result);
})();

//Task 5
(function Task5() {
    var arr = [10, 0, -4, 15, 13, 42, 70, 3, 1, -10, 111];
    var indexOfMin = 0;
    var temp;

    for (var i = 0; i < arr.length - 1; i++) {
        indexOfMin = i;
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[indexOfMin]) {
                indexOfMin = j;
            }
        }

        temp = arr[i];
        arr[i] = arr[indexOfMin];
        arr[indexOfMin] = temp;
    }

    jsConsole.writeLine(arr.join(", "));
})();

//Task 6
(function Task4() {
    var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
    var current;
    var finalElement;
    var maxCount = 1;
    var count = 1;

    for (var i = 0; i < arr.length; i++) {
        if (arr[i] !== null) {
            current = arr[i]
        }
        else {
            continue;
        }

        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] === current) {
                count++;
                arr[j] = null;
            }
        }

        if (count > maxCount) {
            maxCount = count;
            finalElement = current;
            count = 1;
        }
    }

    jsConsole.writeLine(finalElement.toString() + ' -> ' + maxCount + ' times.');
})();

//Task 7
function Task6() {

}