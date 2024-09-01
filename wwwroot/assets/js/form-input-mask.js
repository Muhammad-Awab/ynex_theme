(function() {
    'use strict';

    /* formatting into blocks */
    var c1 = new Cleave('.formatting-blocks', {
        blocks: [4, 3, 3, 4],
        uppercase: true
    });

    /* delimeter */
    var d1 = new Cleave('.delimiter', {
        delimiter: '·',
        blocks: [3, 3, 3],
        uppercase: true
    });

    /* multiple delimeter */
    var d2 = new Cleave('.delimiters', {
        delimiters: ['/', '/', '-'],
        blocks: [3, 3, 3, 2],
        uppercase: true
    });

    /* prefix */
    var p1 = new Cleave('.prefix-element', {
        prefix: 'Prefix',
        delimiter: '-',
        blocks: [6, 4, 4, 4],
        uppercase: true
    });


})();