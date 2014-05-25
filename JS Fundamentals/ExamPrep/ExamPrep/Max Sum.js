function solve(arg) {
    var params = [];

    for (var j = 0; j < arg.length; j++) {
        params[j] = +arg[j];
    }

    var bestSum = -20000000000000;
    

    for (var i = 1; i < params.length; i++) {
        var tempSum = 0;
        for (var j = i; j < params.length; j++) {
            tempSum += params[j];

            if (tempSum > bestSum) {
                bestSum = tempSum;
            }
        }
    }

    console.log(bestSum);
}

var input = [
'-9',
'-8',
'-8',
'-6',
'-5',
'-1',
'-6',
'-7',
];

solve(input);