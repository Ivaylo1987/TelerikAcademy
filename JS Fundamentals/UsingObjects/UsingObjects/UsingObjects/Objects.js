//1.Write functions for working with shapes in  standard Planar coordinate system
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending
//L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points
//Check if three segment lines can form a triangle

(function () {

    function createPoint(xCoord, yCoord) {
        return {
            x: xCoord,
            y: yCoord,
            toString: function () {
                return '(' + this.x + ' ' + this.y + ')';
            }
        }
    }

    var pointA = createPoint(0, 0);
    var pointB = createPoint(1, 10);
    jsConsole.writeLine(pointB); //for test purposes

    function createLine(firstPoint, secondPint) {
        return {
            start: firstPoint,
            end: secondPint,
            toString: function () {
                return this.start + ':' + this.end;
            }
        }
    }

    var line = createLine(pointA, pointB);
    jsConsole.writeLine(line); //for test purposes

    function calcDistanceBetweenpoint(firstPoint, secondPoint) {
        return Math.sqrt(Math.pow((secondPoint.x - firstPoint.x), 2) + Math.pow((secondPoint.y - firstPoint.y), 2));
    }

    var distance = calcDistanceBetweenpoint(pointA, pointB);
    jsConsole.writeLine(distance);// for test purposes

    //find if three lines can form a triangle
    function canFormTriangle(firstLine, secondLine, thirdLine) {
        var firstLineLength = calcDistanceBetweenpoint(firstLine.start, firstLine.end);
        var secondLineLength = calcDistanceBetweenpoint(secondLine.start, secondLine.end);
        var thirdLineLength = calcDistanceBetweenpoint(thirdLine.start, thirdLine.end);

        if (firstLineLength + secondLineLength > thirdLineLength &&
               thirdLineLength + secondLineLength > firstLineLength &&
               firstLineLength + thirdLineLength > secondLineLength) {
            return true;
        }

        return false;
    }

    //2.Write a function that removes all elements with a given value
    //Attach it to the array type
    //Read about prototype and how to attach methods

    Array.prototype.remove = function (value) {
        for (var i = 0; i < this.length; i++) {
            if (arr[i] === value) {
                this.splice(i, 1);
            }
        }
    }

    var arr = [1, 3, 4, 1, 7, '1', '5', 7];
    arr.remove(1); // should remove first two 1s which are of type Number;

    jsConsole.writeLine(arr.join(', '));


    //3.Write a function that makes a deep copy of an object
    //The function should work for both primitive and reference types
    // TODO:


    //4.Write a function that checks if a given object contains a given property

    function hasProp(obj, propName) {
        var has = false;
        for (var prop in obj) {
            if (prop == propName) {
                has = true;
            }
        }

        return has;
    }

    var person = {
        firstName: 'Pesho',
        lastName: 'Ivanov',
        age: 23,
        toString: function () {
            return this.firstName + ' ' + this.lastName;
        }
    }

    jsConsole.writeLine(hasProp(person, 'firstName')); //will return true
    jsConsole.writeLine(hasProp(person, 'firstname')); //will return false


    //5.Write a function that finds the youngest person in a given array of persons and prints his/hers full name
    //Each person have properties firstname, lastname and age, as shown:

    var persons = [
        { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname: 'Bay', lastname: 'Ivan', age: 81 },
        { firstname: 'Pesho', lastname: 'Genadiev', age: 23 },
        { firstname: 'Mariika', lastname: 'Minkova', age: 44 }
    ];

    function findYangest(obj) {
        var minAgePerson;

        for (var i = 0; i < obj.length; i++) {
            if (!minAgePerson) {
                minAgePerson = obj[i];
                continue;
            }

            if (minAgePerson.age > obj[i].age) {
                minAgePerson = obj[i];
            }
        }

        return minAgePerson;
    }

    var yangest = findYangest(persons);
    jsConsole.writeLine(yangest.firstname + ' ' + yangest.lastname);

    //6.
    //Write a function that groups an array of persons by age, first or last name.
    //The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups
    //Use function overloading (i.e. just one function)

    //used to generate people array
    function generatePeople(count) {

        var firstNames = ["Joro", "Marko", "Petko", "Vasko", "Pesho"];
        var lastNames = ["Stamenov", "Draganov", "Petkov", "Simeonov", "Aprilov"];
        var ages = [20, 18, 27, 42, 61];

        function getPerson(fname, lname, age) {
            return {
                firstName: fname,
                lastName: lname,
                age: age,
                toString: function () {
                    return this.firstName + ' ' + this.lastName + ' - ' + age;
                }
            };
        }

        var people = [count];

        for (var i = 0; i < count; i++) {
            people[i] = getPerson(
                    firstNames[Math.floor((Math.random() * firstNames.length))],
                    lastNames[Math.floor((Math.random() * lastNames.length))],
                    ages[Math.floor((Math.random() * ages.length))]
                );
        }

        return people;
    }

    var arrPeople = generatePeople(30);
    jsConsole.writeLine(arrPeople);
})()