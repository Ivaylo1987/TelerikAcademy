var specialConsole = (function () {

    function formatString(input) {
        // calling function arguments are in this functions arguments[0] 
        var functionArguments = arguments[0];
        var result;

        result = functionArguments[0].replace(/\{(\d+)\}/g, function (match, p1) {
            return functionArguments[parseInt(p1) + 1];
        });

        return result;
    }

    function writeLine(message) {
        if (arguments.length <= 1) {
            console.log(message);
        }
        else {
            console.log(formatString(arguments));
        }
    }

    function writeError(message) {
        if (arguments.length <= 1) {
            console.log(message);
        }
        else {
            console.log(formatString(arguments));
        }
    }

    function writeWarning(message) {
        if (arguments.length <= 1) {
            console.log(message);
        }
        else {
            console.log(formatString(arguments));
        }
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }
}())