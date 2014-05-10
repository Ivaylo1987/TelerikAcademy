(function(){
    //1.Write a function that returns the last digit of given integer as an English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine"
    function getLastDigitName(number) {
        switch (number % 10) {
            case 0:
                return 'zero';
            case 1:
                return 'one';
            case 2:
                return 'two';
            case 3:
                return 'three';
            case 4:
                return 'four';
            case 5:
                return 'five';
            case 6:
                return 'six';
            case 7:
                return 'seven';
            case 8:
                return 'eight';
            case 9:
                return 'nine';
            default: return 'Invalid Number'
        }
    }

    jsConsole.writeLine(getLastDigitName(156));
    jsConsole.writeLine(getLastDigitName(12309));

    //2.Write a function that reverses the digits of given decimal number. Example: 256 -> 652
    function reverseDigits(num) {
        return num.toString().split('').reverse().join('');//split the string into charr array, reverse it and then join it back.
    }

    jsConsole.writeLine(reverseDigits(1234));


    //3.Write a function that finds all the occurrences of word in a text
    //The search can case sensitive or case insensitive
    //Use function overloading
    function findOccurances(word, text, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;
        var pattern = '\\b' + word + '\\b';
        var regex;
        var result;
        if (isCaseSensitive) {
            regex = new RegExp(pattern, 'g');
            result = text.match(regex) ? text.match(regex).length : 0;
            return result;
        }
        else {
            regex = new RegExp(pattern, 'gi');
            result = text.match(regex) ? text.match(regex).length : 0;
            return result;
        }
    }

    jsConsole.writeLine(findOccurances('oranges', 'Oranges are yellow and oranges are juicy', true)); //case sensitive
    jsConsole.writeLine(findOccurances('oranges', 'Oranges are yellow and oranges are juicy')); //case insansitive
    jsConsole.writeLine(findOccurances('BLABLA', 'Oranges are yellow and oranges are juicy')); // 0 occurances

    //4.Write a function to count the number of divs on the web page
    function countDivs() {
        return document.getElementsByTagName('div').length;
    }

    jsConsole.writeLine(countDivs()); //will retunr 1 the div of the jsConsole.

    //5.Write a function that counts how many times given number appears in given array.
    function countElementOccurances(arr, key) {
        var result = 0;

        for (var i = 0; i < arr.length; i++) {
            if (key === arr[i]) {
                result++;
            }
        }

        return result;
    }

    var occurances = countElementOccurances([1, 2, 5, 5, - 1, -17, 33, 90, 5, 0, 5], 5);
    jsConsole.writeLine(occurances);

    //6.Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
    function isBiggerThanNeighbours(arr, position){
        switch (position) {
            case 0:
                return arr[0] > arr[1];
            case arr.length -1:
                return arr[arr.length - 1] > arr[arr.length - 2];
            default:
                return (arr[position] > arr[position - 1] && arr[position] > arr[position + 1]);
        }
    }
    jsConsole.writeLine(isBiggerThanNeighbours([1, 2, 4, 1, 1, 1, 5], 2));//shoudl return true
    jsConsole.writeLine(isBiggerThanNeighbours([1, 2, 4, 1, 1, 1, 5], 3)); //shoudl return false

    //7.Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
    //Use the function from the previous exercise.
    function firstBiggerThanNeighbours(arr) {
        for (var i = 0; i < arr.length; i++) {
            if (isBiggerThanNeighbours(arr, i)) {
                return i;
            }
        }

        return -1;
    }

    jsConsole.writeLine(firstBiggerThanNeighbours([0, 0, 0, 0, 0, 0, 0]));//shoudl return -1
    jsConsole.writeLine(firstBiggerThanNeighbours([1, 2, 4, 1, 1, 1, 5]));//shoudl return 2

})()