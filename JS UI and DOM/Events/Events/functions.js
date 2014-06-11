window.onload = function () {
    var textArea = document.getElementById('textArea');
    var select = document.getElementById('select');
    var addBtn = document.getElementById('add');
    var removeBtn = document.getElementById('remove');

    addBtn.addEventListener('click', function () {
        if (textArea.value) {
            var newOption = document.createElement('option');
            newOption.innerHTML = textArea.value;
            newOption.id = select.children.length + 1;
            select.appendChild(newOption);
            textArea.value = '';
        }
    });

    removeBtn.addEventListener('click', function () {
        var options = select.children;
        for (var i = 0; i < options.length; i++) {
            if (options[i].selected) {
                select.removeChild(options[i]);
            }
        }
    });
}