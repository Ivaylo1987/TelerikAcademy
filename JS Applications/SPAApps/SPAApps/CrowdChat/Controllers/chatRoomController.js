/// <reference path="E:\Docs\GitRepos\TelerikAcademy\JS Applications\SPAApps\SPAApps\Scripts/_references.js" />
define(['viewLoader', 'jQuery', 'mustache', 'requester'], function (viewLoader, jQ, mustache, requester) {
    var viewURL = 'Views/chatRoomView.html';

    var renderTemplate = function (template, data) {
        var rendered = mustache.render(template, data);
        return rendered;
    }

    var sendToChat = function () {
        var input = {};
        input.user = sessionStorage.getItem('username');
        input.text = $('#input-textarea').val();
        requester.post('http://crowd-chat.herokuapp.com/posts', input);
    }

    var getLatestMessages = function () {
        requester.get('http://crowd-chat.herokuapp.com/posts')
               .then(function (data) {
                   var usersTemplate = $('#user-template').html();
                   $('#chat-messages').html('');

                   for (var i = data.length; i >= data.length - 10; i--) {
                       if (data[i]) {
                           var renderedUser = renderTemplate(usersTemplate, { senderName: data[i].by, message: data[i].text });
                           $('#chat-messages').append(renderedUser);
                       }
                   }
               })
    }

    var run = function (container) {
        viewLoader.loadView(viewURL)
            .then(function (view) {
                $(container).html(view);
                $('#submit-button').on('click', sendToChat);
                setInterval(getLatestMessages, 1000);
            }, function (error) {
                console.log(error);
            });
    }

    return {
        run: run
    }
})