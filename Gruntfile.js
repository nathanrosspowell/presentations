module.exports = function(grunt) {
    // Project configuration.
    grunt.initConfig({
        copy: {
            main: {
                files: [
                    {
                        cwd: 'src/website/',
                        src: ['**/*'],
                        dest: 'build/',
                        expand: true, 
                    }
                ]
            }
        },
        'compile-handlebars': {
            programmer_talk: {
                template: [
                    'src/child_page/template.handlebars',
                    'src/remark/header.handlebars',
                ],
                templateData: [
                    'src/beginner_guides/programmer_talk/meta.json',
                    'src/beginner_guides/programmer_talk/meta.json',
                ],
                output: [
                    'build/beginner_guides/programmer_talk/index.html',
                    'temp/beginner_guides/programmer_talk/presentation/index.html',
                ],
            },
            language_syntax: {
                template: [
                    'src/child_page/template.handlebars',
                    'src/remark/header.handlebars'
                ],
                templateData: [
                    'src/beginner_guides/language_syntax/meta.json',
                    'src/beginner_guides/language_syntax/meta.json'
                ],
                output: [
                    'build/beginner_guides/language_syntax/index.html',
                    'temp/beginner_guides/language_syntax/presentation/index.html'
                ],
            }

        },
        concat: {
            main: {
                files: {
                    // programmer_talk
                    'build/beginner_guides/programmer_talk/presentation/index.html' : [
                        'temp/beginner_guides/programmer_talk/presentation/index.html',
                        'src/beginner_guides/programmer_talk/README.md',
                        'src/remark/footer.html' ],
                    // language_syntax
                    'build/beginner_guides/language_syntax/presentation/index.html' : [
                        'temp/beginner_guides/language_syntax/presentation/index.html',
                        'src/beginner_guides/language_syntax/README.md',
                        'src/remark/footer.html' ],
                    // Main Index.
                    'build/test/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/test.md',
                        'src/remark/footer.html' ]
                },
            }
        },
        'gh-pages': {
            main: {
                options: {
                    base: 'build'
                },
                src: ['**']
            }
        }
    });
    // Load tasks.
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-compile-handlebars');
    grunt.loadNpmTasks('grunt-gh-pages');
    // Default task: does everything except deployment
    grunt.registerTask('default', ['copy', 'compile-handlebars', 'concat' ]);
    // Deploy task: runs everything in order.
    grunt.registerTask('deploy', ['default', 'gh-pages']);
};
