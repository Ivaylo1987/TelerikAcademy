var path = require('path');
var rootPath = path.normalize(__dirname + '/../');

module.exports = {
    development: {
        rootPath: rootPath,
        databaseConnection: 'mongodb://localhost:27017/cvCreator',
        port: process.env.PORT || 3001
    }
}