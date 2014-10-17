var multiparty = require('multiparty');
var http = require('http');
var url = require("url");

http.createServer(function(req, res) {
    // Simple path-based request dispatcher
    switch (url.parse(req.url).pathname) {
        case '/':
            showUploadForm(req, res);
            break;
        case '/upload':
            parseForm(req, res);
            break;
        default:
            break;
    }

}).listen(8080);

console.log("Server listening on port: 8080");

function showUploadForm(req, res) {
    res.writeHead(200, {'content-type': 'text/html'});
    res.end(
            '<form action="/upload" enctype="multipart/form-data" method="post">'+
            '<input type="file" name="upload" multiple="multiple"><br>'+
            '<input type="submit" value="Upload">'+
            '</form>'
    );
}

function parseForm(req, res) {
    var form = new multiparty.Form({
        uploadDir: __dirname + "/uploads/",
        hash: "sha1"
    });

    form.parse(req, function (err, fields, files) {
        res.end(files.upload[0].path);
        console.log(files);
    });
}