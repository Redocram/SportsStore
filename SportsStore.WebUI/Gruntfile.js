module.exports = function (grunt) {

  // Project configuration.
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    sass: {                              // Task 
      dist: {                            // Target 
        options: {                       // Target options 
          style: 'expanded'
        },
        files: {                         // Dictionary of files 
          './Content/CustomContent/CustomStyle.css': './Content/CustomContent/CustomStyle.scss'       // 'destination': 'source' 
        }
      }
    },
    watch: {
        files: ['Content/CustomContent/CustomStyle.scss'],
        tasks: ['sass'],
        options: {
          spawn: false
        }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-sass');
  grunt.loadNpmTasks('grunt-contrib-watch');

  grunt.registerTask('default', ['sass']);
};