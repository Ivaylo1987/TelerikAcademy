(function () {
    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net",
        "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];

    // Random generator for the inclusive interval
    function randomGenerator(from, to) {
        var limit = to - from;
        var random = Math.floor((Math.random() * limit) + 1);

        return from + random;
    }

    // Generate div
    function generateDivs(value, size) {

        var div = document.createElement('div');
        var strong = document.createElement('strong');

        div.style.display = 'inline-block';
        div.style.position = 'absolute';
        div.style.left = randomGenerator(20, 1000) + 'px';
        div.style.top = randomGenerator(20, 500) + 'px';

        strong.innerHTML = value;
        strong.style.fontSize = size + 'px';
        div.appendChild(strong);

        return div;
    }

    // Generates Tag could with overlapping tags
    function generateTagcloud(tags, minSize, maxSize) {
        var tagsCount = {};
        var dFragment = document.createDocumentFragment();
        var minCount = tags.length;
        var maxCount = 0;

        // Get associative array with tags and their count.
        for (var i = 0, len = tags.length; i < len; i++) {
            if (tagsCount[tags[i]]) {
                tagsCount[tags[i]]++;
            }
            else {
                tagsCount[tags[i]] = 1;
            }
        }

        // find min count and max count
        for (var tag in tagsCount) {
            if (maxCount < tagsCount[tag]) {
                maxCount = tagsCount[tag];
            }
            if (tagsCount[tag] < minCount) {
                minCount = tagsCount[tag];
            }
        }

        // generate divs according the number of occurances
        for (var tag in tagsCount) {
            if (tagsCount[tag] == maxCount) {
                dFragment.appendChild(generateDivs(tag, maxSize));
            }
            if (tagsCount[tag] == minCount) {
                dFragment.appendChild(generateDivs(tag, minSize));
            }
            else {
                var size = minSize + ((maxSize - minSize) * tagsCount[tag] / maxCount);
                dFragment.appendChild(generateDivs(tag, size));
            }
        }

        document.body.appendChild(dFragment);
    }

    generateTagcloud(tags, 17, 47);
})()