function solve(args) {
    var matrixRows = args[0].split(' ').map(Number)[0];
    var matrixCows = args[0].split(' ').map(Number)[1];
    var startPosition = args[1].split(' ').map(Number);
    var position = {
        row: startPosition[0],
        col: startPosition[1]
    };
    var dirList = args.slice(2);
    var directions = {
        l: {
            row: 0,
            col: -1
        },
        r: {
            row: 0,
            col: 1
        },
        u: {
            row: -1,
            col: 0
        },
        d: {
            row: 1,
            col: 0
        }
    }

    var counter = 1;
    var field = [];

    for (var i = 0; i < matrixRows; i++) {
        field[i] = [];
        for (var j = 0; j < matrixCows; j++) {
            field[i][j] = counter++;
        }
    }
    var sumOfNumbers = 0;
    var numberOfCells = 0;
    
    

    while (true) {
        if (position.row < 0 || position.col < 0 ||
            position.row >= matrixRows || position.col >= matrixCows) {

            return console.log('out ' + sumOfNumbers);
        }

        if (field[position.row][position.col] == 'visited') {
            return console.log('lost ' + numberOfCells);
        }

        sumOfNumbers += field[position.row][position.col];
        numberOfCells++;

        field[position.row][position.col] = 'visited';
        var nextDirection = directions[dirList[position.row][position.col]];
        position.row = position.row + nextDirection.row;
        position.col = position.col + nextDirection.col;
    }
}

var test1 = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"
]

solve(test1);