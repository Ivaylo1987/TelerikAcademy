/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\UnderscoreJS\UnderscoreJS\scripts/_references.js" />
(function () {
    var students = [{
        firstName: 'Pesho',
        lastName: 'Stoyanov',
        age: 22,
        marks: [6, 5, 6, 6, 6]
    }, {
        firstName: 'Ivaylo',
        lastName: 'Kenov',
        age: 18,
        marks: [6, 5, 3, 6, 6]
    }, {
        firstName: 'Nikolay',
        lastName: 'Kostov',
        age: 30,
        marks: [3, 5, 3, 4, 6]
    }, {
        firstName: 'Doncho',
        lastName: 'Minkov',
        age: 26,
        marks: [6, 5, 5, 4, 3]
    }, {
        firstName: 'Maria',
        lastName: 'Hristova',
        age: 24,
        marks: [6, 6, 3, 4, 6]
    }]

    /* 
    1. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    Print the students in descending order by full name. Use Underscore.js
    */
    var findFirstBeforeLast = function (arr) {
        // chaining used for ease.
        var result = _.chain(arr)
            .filter(function (item) {
                return item.firstName.toLowerCase() < item.lastName.toLowerCase();
            })
            .sortBy(function (item) {
                return item.firstName + ' ' + item.lastName;
            })
            .value()   // breaks the chaning and returns the value.

        console.log(result);
    }

    /*
    2. Write function that finds the first name and last name of all students with age between 18 and 24. Use Underscore.js
     */
    var filterByAgeInterval = function (arr, startValue, endValue) {
        var result = _.filter(arr, function (item) {
            return startValue <= item.age && item.age <= endValue;
        })

        console.log(result);
    }

    /*
    3.Write a function that by a given array of students finds the student with highest marks
     */
    var findWithHighestMarks = function (arr) {
        var result = _.max(arr, function (item) {
            // find the sum of all marks and return it to the .max function
            var sumOfMarks = _.reduce(item.marks, function (memo, num) { return memo + num; }, 0)
            return sumOfMarks;
        })

        console.log(result);
    }

    console.log('Ordered by first name before last name:');
    findFirstBeforeLast(students);

    console.log('Age between 18 and 24:');
    filterByAgeInterval(students, 18, 24);

    console.log('Student with highest marks:');
    findWithHighestMarks(students);
}())