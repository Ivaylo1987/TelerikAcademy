/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\UnderscoreJS\UnderscoreJS\Scripts/_references.js" />
(function () {
    var books = [{
        title: "Book Title 1",
        author: "Author A"
    }, {
        title: "Book Title 2",
        author: "Author B"
    }, {
        title: "Book Title 3",
        author: "Author A"
    }, {
        title: "Book Title 4",
        author: "Author C"
    }, {
        title: "Book Title 5",
        author: "Author A"
    }, {
        title: "Book Title 6",
        author: "Author D"
    }, {
        title: "Book Title 7",
        author: "Author E"
    }, {
        title: "Book Title 8",
        author: "Author F"
    }, {
        title: "Book Title 9",
        author: "Author A"
    }, {
        title: "Book Title 10",
        author: "Author J"
    }, {
        title: "Book Title 11",
        author: "Author H"
    }, ];

    /*
     * 6. By a given collection of books, find the most popular author (the author with the highest number of books)
     */

    var findMostPopilarAuthor = function (arr) {

        // cout each author occurances, than pair in array of key(author) - value(occurances) items, then find max by value of occurances.
        var result = _.chain(arr)
            .countBy('author')
            .pairs()
            .max(function (item) {
                return item[1]
            })
            .value()


        console.log(result);
    }

    findMostPopilarAuthor(books);

}())