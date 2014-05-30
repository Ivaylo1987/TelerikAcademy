(function () {
    //---To see result, please open JS console in your preferred browser---//
    // Task 2
    function getValue() {
        var inputOne = document.getElementById('inputOne');
        console.log(inputOne.value);
    }

    var buttonGetValue = document.getElementById('getValueButton');
    buttonGetValue.addEventListener('click', getValue, false);
    

    // Task 3
    function changeColor() {
        var colorElement = document.getElementById('inputTwo');
        document.body.bgColor = colorElement.value;
    }

    var buttonChangeColor = document.getElementById('changeBGColor');
    buttonChangeColor.addEventListener('click', changeColor, false);
})()