var wkhtmltopdf = require('wkhtmltopdf');
var fs = require('fs');

wkhtmltopdf('http://localhost:3001/cv/create', { pageSize: 'letter' })
  .pipe(fs.createWriteStream('out1.pdf'));
  
 console.log('Done!');