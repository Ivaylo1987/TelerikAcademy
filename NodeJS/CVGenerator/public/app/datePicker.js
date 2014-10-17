$(function () {
    $('.input-daterange').datepicker({});

    $('#add-job').on('click', function () {
        var containers = $('#experience > .job-container');
        var last = containers.last();
        var current = containers.length;

        var newContainer = last.clone(true);

        newContainer.find('.titleLabel').attr('for', 'title_' + current);
        var inputTitle = newContainer.find('#title_' + (current - 1));
        inputTitle.attr('id', 'title_'+ current);
        inputTitle.attr('name', 'title_'+ current);

        newContainer.find('.companyLabel').attr('for', 'company_' + current);
        var inputCompany = newContainer.find('#company_' + (current - 1));
        inputCompany.attr('id', 'company_'+ current);
        inputCompany.attr('name', 'company_'+ current);

        var from = newContainer.find('.from');
        from.attr('name', 'from_' + current);

        var to = newContainer.find('.to');
        to.attr('name', 'to_' + current);

        $('#add-job').before(newContainer);
    });

//    $('.remove-job').on('click', function () {
//        var parent = $(this).parent();
//        parent.remove();
//    });

    $('#add-cert').on('click', function () {
        var containers = $('#certifications > .cert-container');
        var last = containers.last();
        var current = containers.length;

        var newContainer = last.clone();

        var titleLabel = newContainer.find('.title-label');
        titleLabel.attr('for', 'certification_' + current);

        var titleInput = newContainer.find('#certification_' + (current - 1));
        titleInput.attr('id', 'certification_' + current);
        titleInput.attr('name', 'certification_' + current);

        var decriptionLabel = newContainer.find('.description-label');
        decriptionLabel.attr('for', 'certDescription_' + current);

        var certInput = newContainer.find('#certDescription_' + (current - 1));
        certInput.attr('id', 'certDescription_' + current);
        certInput.attr('name', 'certDescription_' + current);

        $('#add-cert').before(newContainer);
    });
});