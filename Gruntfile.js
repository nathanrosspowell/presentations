//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var fs = require('fs');
var path = require('path');
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
module.exports = function(grunt) {
    grunt.loadNpmTasks('grunt-replace');
    // Project configuration.
    grunt.initConfig({
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        concat: {
            main: {
                files: {
                    'build/index.html': ['src/index.html'],
                    'build/test/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/test.md',
                        'src/remark/footer.html' ]
                },
            }
        },
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'gh-pages': {
            main: {
                options: {
                    base: 'build'
                },
                src: ['**']
            }
        }
    });
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Load tasks.
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-gh-pages');
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    // Default task: does everything except deployment
    grunt.registerTask('default', ['concat']);
    // deploy task: runs everything in order.
    grunt.registerTask('deploy', ['default', 'gh-pages']);
};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
