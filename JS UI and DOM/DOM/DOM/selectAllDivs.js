//---To see result, please open JS console in your preferred browser---//

(function () {
    // Task 1 with querySelectorAll();
    function selectDivsQuerySelector() {
        var divsInDiv = document.querySelectorAll('div > div')
        return divsInDiv; // returns NodeList
    }

    console.log(selectDivsQuerySelector()); 

    // Task 1 with getElementsBy();
    function selectDivsGetElementsByTagName() {
        var divs = document.getElementsByTagName('div');
        var result = [];

        for (var i = 0, iLen = divs.length; i < iLen; i++) {
            for (var j = 0, jLen = divs[i].children.length; j < jLen; j++) {
                if (divs[i].children[j].nodeName = 'DIV') {
                    result.push(divs[i].children[j]);
                }
            }
        }

        return result; // returns Array
    }

    console.log(selectDivsGetElementsByTagName());
})()