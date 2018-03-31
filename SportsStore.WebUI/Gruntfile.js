module.exports = function (grunt) {

  // Project configuration.
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),   
    watch: {
        files: ['Content/Css/Sass/**/**.scss'],
        tasks: ['sass'],
        options: {
          spawn: false
        }
    },
    sass: {                              // Task 
        dist: {                            // Target 
            options: {                       // Target options 
                style: 'expanded'
            },
            files: {                         // Dictionary of files 
                './Content/Css/main.css': './Content/Css/Sass/**/*.scss'       // 'destination': 'source' 
            }
        }
    },
    browserSync: {
        dev: {
            bsFiles: {
                src: [
                    './Content/Css/CustomStyle.css',
                    './Views/**/*.cshtml'
                ]
            },
            options: {
                watchTask: true,
                proxy: 'localhost:52617',
                tunnel: true
            }
        }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-sass');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-browser-sync');

  grunt.registerTask('default', ['browserSync', 'watch']);
};