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
        concat: {
            main: {
                files: {
                    // programmer_talk
                    'build/beginner_guides/programmer_talk/presentation/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/programmer_talk/README.md',
                        'src/remark/footer.html' ],
                    'build/beginner_guides/programmer_talk/index.html' : [
                        'src/child_page/header.html',
                        'src/markdown/beginner_guides/programmer_talk/index.html',
                        'src/child_page/footer.html' ],
                    // Old
                    'build/beginner_guides/language_syntax/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/language_syntax.md',
                        'src/remark/footer.html' ],
                    'build/beginner_guides/how_a_computer_works/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/how_a_computer_works.md',
                        'src/remark/footer.html' ],
                    'build/beginner_guides/why_crashes_happen/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/why_crashes_happen.md',
                        'src/remark/footer.html' ],
                    'build/beginner_guides/make_your_own_program/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/make_your_own_program.md',
                        'src/remark/footer.html' ],
                    'build/beginner_guides/post_mortem/index.html' : [
                        'src/remark/header.html',
                        'src/markdown/beginner_guides/post_mortem.md',
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
    grunt.loadNpmTasks('grunt-gh-pages');
    // Default task: does everything except deployment
    grunt.registerTask('default', ['copy', 'concat']);
    // Deploy task: runs everything in order.
    grunt.registerTask('deploy', ['default', 'gh-pages']);
};
