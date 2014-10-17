'use strict';
var mongoose = require('mongoose');

var fileSchema = mongoose.Schema({
    url: String,
    private: Boolean
});

var File = mongoose.model('File', fileSchema);