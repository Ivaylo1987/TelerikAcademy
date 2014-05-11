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


})()