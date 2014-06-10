(function() {
    var firstSlide = document.getElementById('firstSlide');
    var fsecondSlide = document.getElementById('secondSlide');
    var textArea = document.getElementById('textArea');

    firstSlide.addEventListener('change', function () {
        textArea.style.color = firstSlide.value;
    });

    secondSlide.addEventListener('change', function () {
        textArea.style.backgroundColor = secondSlide.value;
    });
})()