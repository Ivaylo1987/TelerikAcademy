var UsersController = require('./UsersController');
var FilesController = require('./FilesController');
var CV = require('./CVController');

module.exports = {
    users: UsersController,
    files: FilesController,
    cv: CV
};