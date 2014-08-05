/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\ExamJSApplications\ExamJSApplications\Scripts/_references.js" />
define(['viewLoader', 'requester', 'q', 'jQuery'], function (viewLoader, requester, Q) {
    var viewURL = '../Views/postsView.html';
    var user = {};

    var run = function (container, serviceURL) {
        function sortBy(data, by) {
            var arr = data.slice();
            
            arr.sort(function (a, b) {
                if (by === 'title') {
                    a = a[by].toLowerCase();
                    b = b[by].toLowerCase();
                } else {
                    a = a[by];
                    b = b[by];
                }
                if (a > b)
                    return -1;
                if (a < b)
                    return 1;
                return 0;
            });

            return arr;
        }

        var loadPostPanel = function () {
            var submitData = {};
            $('#ask-to-log').hide();
            $('#post-container').show();

            $('#submit-button').on('click', function () {
                submitData.title = $('#title').val();
                submitData.body = $('#body').val();

                var input = JSON.parse(sessionStorage.getItem('user'));
                var sessionKey = input.sessionKey;
                var headers = { 'X-SessionKey': sessionKey };

                requester.post(serviceURL, submitData, headers)
                    .then(function (data) {
                        loadAllMessagesToHtml();
                    }, function (error) {
                        var customerError = JSON.parse(error.responseText);
                        alert(customerError.message);
                    });
            });
        }

        var sortByTitle = function () {
            requester.get(serviceURL)
                .then(function (data) {
                    var sorted = sortBy(data, 'title');
                    appendToList(sorted);
                }, function (error) {
                    console.log(error);
                });
        }

        var fileterByAuthor = function () {
            if (sessionStorage.length !== 0) {
                var input = JSON.parse(sessionStorage.getItem('user'));

                var url = serviceURL + '?' + 'user=' + input.username
                requester.get(url)
                    .then(function (data) {
                        appendToList(data);
                    }, function (error) {
                        console.log(error);
                    });
            }
        }

        var fileterByAuthorAndPatter = function () {
            if (sessionStorage.length !== 0) {
                var input = JSON.parse(sessionStorage.getItem('user'));

                var url = serviceURL + '?' + 'pattern=' + 'user=' + input.username
                requester.get(url)
                    .then(function (data) {
                        appendToList(data);
                    }, function (error) {
                        console.log(error);
                    });
            }
        }

        var fileterByPattern = function () {
            var input = JSON.parse(sessionStorage.getItem('user'));
            var pattern = $('#pattern').val();

            var url = serviceURL + '?' + 'pattern=' + pattern;
            requester.get(url)
                .then(function (data) {
                    appendToList(data);
                }, function (error) {
                    console.log(error);
                });
        }

        var sortByDate = function () {
            requester.get(serviceURL)
                .then(function (data) {
                    var sorted = sortBy(data, 'date');
                    appendToList(sorted);
                }, function (error) {
                    console.log(error);
                });
        }

        var appendToList = function (data) {
            var list = $('#messages-list');
            list.html('');

            for (var i = data.length - 1; i >= 0 ; i--) {
                var listItem = $('<li />').addClass('list-item');
                var title = $('<h4 />').append(data[i].title);
                var body = $('<p />').append(data[i].body);

                listItem.append(title);
                listItem.append(body);
                list.append(listItem);
            }
        }

        var loadAllMessagesToHtml = function () {
            requester.get(serviceURL)
                .then(function (data) {
                    appendToList(data);
                }, function (error) {
                    console.log(error);
                });
        }

        viewLoader.loadView(viewURL)
            .then(function (data) {
                $(container).html(data);
                $('#post-container').hide();
                $('#ask-to-log').show();

                if (sessionStorage.length !== 0) {
                    loadPostPanel();
                }

                $('#sort-by-title').on('click', function () {
                    sortByTitle();
                })

                $('#sort-by-date').on('click', function () {
                    sortByDate();
                })

                $('#filter-by-autor').on('click', function () {
                    fileterByAuthor();
                })

                $('#filter-by-pattern').on('click', function () {
                    fileterByPattern();
                })

                loadAllMessagesToHtml();
            });
    };

    return {
        run: run
    }
})