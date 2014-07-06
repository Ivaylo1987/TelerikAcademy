define(["jquery", "handlebars"], function () {
    $.fn.templateEngine = function (data) {
        var $this = $(this);

        // Gets the template structure
        var templateID = $this.attr('data-template');

        // Compiles the template
        var tepmplateCode = $("#" + templateID);
        var templateHtml = tepmplateCode.html();
        var compiledTemplate = Handlebars.compile(templateHtml);

        // Uses input to populate the template
        for (var i = 0, len = data.length; i < len; i++) {
            $this.append(compiledTemplate(data[i]));
        }

        return $this;
    }
});