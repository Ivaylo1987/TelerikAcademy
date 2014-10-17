'use strict';
var User = require('mongoose').model('User');
var CV = require('mongoose').model('CV');

var controllerName = 'cv';

module.exports= {
    getCreateCV: function (req, res, next) {
        res.render(controllerName + '/createCV');
    },
    getCVMain: function (req, res, next) {
        res.render(controllerName + '/cvMain');
    },
    postCreateCV: function (req, res, next) {
        var body = req.body;
        var cv = {};
        cv.user = req.user._id;
        cv.name = body.name;
        cv.email= body.email;
        cv.age = body.age;
        cv.address = body.address;

    }
};

//{ name: 'dada',
//    age: '1',
//    email: 'dada',
//    address: 'dad',
//    title_0: '',
//    company_0: '',
//    from_0: '10/09/2014',
//    to_0: '10/14/2014',
//    skills: '',
//    languages: '',
//    certification_0: '',
//    certDescription_0: '' }
