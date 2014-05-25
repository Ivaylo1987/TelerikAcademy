function solve(input) {
    var count = 1;
    for (var i = 2; i < input.length; i++) {
        if (+input[i - 1] > +input[i]) {
            count++;
        }
    }
    console.log(count);
}

var params = [
'7',
'1',
'2',
'-3',
'4',
'4',
'0',
'1'
];

solve(params);