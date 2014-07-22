/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\UnderscoreJS\UnderscoreJS\scripts/_references.js" />
(function () {
    var animals = [{
        specie: "Bird",
        type: "Eagle",
        numberOfLegs: 2
    }, {
        specie: "Bird",
        type: "Raven",
        numberOfLegs: 2
    }, {
        specie: "Mammal",
        type: "Cow",
        numberOfLegs: 4
    }, {
        specie: "Mammal",
        type: "Human",
        numberOfLegs: 2
    }, {
        specie: "Mammal",
        type: "Cat",
        numberOfLegs: 4
    }, {
        specie: "Mammal",
        type: "Dog",
        numberOfLegs: 4
    }, {
        specie: "Reptile",
        type: "Aligator",
        numberOfLegs: 4
    }, {
        specie: "Reptile",
        type: "Lizard",
        numberOfLegs: 4
    }, {
        specie: "Reptile",
        type: "Turtle",
        numberOfLegs: 4
    }, {
        specie: "Insect",
        type: "Ant",
        numberOfLegs: 6
    }, {
        specie: "Insect",
        type: "Centipede",
        numberOfLegs: 100
    }, {
        specie: "Insect",
        type: "Bee",
        numberOfLegs: 6
    }, {
        specie: "Insect",
        type: "Fly",
        numberOfLegs: 6
    }, {
        specie: "Insect",
        type: "Cockroach",
        numberOfLegs: 6
    }, {
        specie: "Arachnid",
        type: "Acar",
        numberOfLegs: 8
    }, {
        specie: "Arachnid",
        type: "Spider",
        numberOfLegs: 8
    }, {
        specie: "Arachnid",
        type: "Thelyphonida",
        numberOfLegs: 8
    }];


    /*
     * 4. Write a function that by a given array of animals, groups them by species and sorts them by number of legs.
    */
    var groupBySpecieSorrtByLegs = function (arr) {
        var groups = _.chain(arr)
            .groupBy('specie')
            .map(function (groupMemebers) {
                var sortedMember = _.sortBy(groupMemebers, function (member) {
                    return member.numberOfLegs;
                })

                return sortedMember;
            })
            .value()

        console.log(groups);
    }

    /*
     * 5. By a given array of animals, find the total number of legs. Each animal can have 2, 4, 6, 8 or 100 legs
     */
    var findTotalNumberOfLegs = function (arr) {
        var numberOfLegs = 0;
        _.each(arr, function (item) {
            numberOfLegs += item.numberOfLegs;
        })

        console.log(numberOfLegs);
    }

    groupBySpecieSorrtByLegs(animals);

    console.log('Total number of legs:');
    findTotalNumberOfLegs(animals);
}())