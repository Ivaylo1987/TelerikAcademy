window.onload = function () {
    // Get random number in the inclusive interval.
    function randomGenerator(from, to) {
        var limit = to - from;
        var random = Math.floor((Math.random() * limit) + 1);

        return from + random;
    }

    // Get random color
    function getRandomColor() {
        red = randomGenerator(0, 255);
        green = randomGenerator(0, 255);
        blue = randomGenerator(0, 255);

        return "rgb(" + red + "," + green + "," + blue + ")";
    };

    // Generate divs
    function generateDivs() {
        // generate divs
        var divCount = randomGenerator(10, 20);
        var fragment = document.createDocumentFragment();

        for (var i = 0; i <= divCount; i++) {

            var div = document.createElement('div');
            var strong = document.createElement('strong');
            strong.innerHTML = 'DIV';

            div.style.width = randomGenerator(50, 100) + 'px';
            div.style.height = randomGenerator(20, 50) + 'px';
            div.style.position = 'absolute';
            div.style.left = randomGenerator(20, 1200) + 'px';
            div.style.top = randomGenerator(20, 600) + 'px';
            div.style.borderRadius = randomGenerator(1, 10) + 'px';
            div.style.borderWidth = randomGenerator(1, 20) + 'px';
            div.style.borderColor = getRandomColor();
            div.style.backgroundColor = getRandomColor();

            div.appendChild(strong);

            fragment.appendChild(div);
        }

        document.body.appendChild(fragment);
    }

    var generateBtn = document.getElementById('generate');

    generateBtn.addEventListener('click', generateDivs);
}