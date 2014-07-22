/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\UnderscoreJS\UnderscoreJS\Scripts/_references.js" />
(function () {
    var people = [{
        firstName: "Pesho",
        lastName: "Ivanov"
    }, {
        firstName: "Pesho",
        lastName: "Ivanov"
    }, {
        firstName: "Pesho",
        lastName: "Ivanov"
    }, {
        firstName: "Ivan",
        lastName: "Goshov"
    }, {
        firstName: "Gosho",
        lastName: "Goshov"
    }, {
        firstName: "Stamat",
        lastName: "Goshov"
    }, {
        firstName: "Kencho",
        lastName: "Ivaylov"
    }, {
        firstName: "Mincho",
        lastName: "Ivanov"
    }, {
        firstName: "Kosta",
        lastName: "Ivanov"
    }, {
        firstName: "Pesho",
        lastName: "Peshov"
    }, ];

    /*
      7. By an array of people find the most common first and last name.
    */

    var getMostFrequetFirstName = function (arr) {
        var result = _.chain(arr)
            .countBy('firstName')
            .pairs()
            .max(function (item) {
                return item[1];
            })
            .value()

        console.log(result)
    }

    var getMostFrequetLastName = function (arr) {
        var result = _.chain(arr)
            .countBy('lastName')
            .pairs()
            .max(function (item) {
                return item[1];
            })
            .value()

        console.log(result)
    }

    getMostFrequetFirstName(people);
    getMostFrequetLastName(people);
}())