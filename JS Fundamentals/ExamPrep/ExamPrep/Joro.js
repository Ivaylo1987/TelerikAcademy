function solve(params) {
    function getInputToNumber(param) {
        return param.split(' ').map(Number);
    }

    var rowsColsAndJums = getInputToNumber(params[0]);
    var startposition = getInputToNumber(params[1]);
    var jumps = [];
    var junp = {};

    for (var i = 2; i < params.length; i++) {
        jump = {
            row: getInputToNumber(params[i])[0],
            col: getInputToNumber(params[i])[1]
        };
            jumps.push(jump);
    }

    var counter = 1;
    var terrain = [];

    for (var row = 0; row < rowsColsAndJums[0]; row++) {
        terrain[row] = [];
        for (var col = 0; col < rowsColsAndJums[1]; col++) {
            terrain[row][col] = counter++;
        }
    }

    var position = {
        row: startposition[0],
        col: startposition[1]
    }
    var sumOfNumbers = 0;
    var numberOfJumps = 0;
    var nextJump = jumps[0];
    var jumpIndex = -1;

    while (true) {
        if (position.row < 0 || position.col < 0 ||
                position.row >= rowsColsAndJums[0] ||
                position.col >= rowsColsAndJums[1]) {
            return console.log('escaped ' + sumOfNumbers);
        }

        if (terrain[position.row][position.col] == 'X') {
            return console.log('caught ' + numberOfJumps);
        }

        sumOfNumbers += terrain[position.row][position.col];
        numberOfJumps++;
        terrain[position.row][position.col] = 'X';

        jumpIndex++;
        jumpIndex = jumpIndex % jumps.length;
        nextJump = jumps[jumpIndex];
        position.row = position.row + nextJump.row;
        position.col = position.col + nextJump.col;

    }
}

var input = ['6 7 3', '0 0', '2 2', '-2 2', '3 -1'];

solve(input);