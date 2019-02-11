var gulp = require('gulp');
var gulpConnect = require('gulp-connect');
var webpackStream = require('webpack-stream');
var named = require('vinyl-named');
var providePlugin = require('webpack-stream').webpack.ProvidePlugin;

gulp.task('server', function () {
    gulpConnect.server({
        root: 'app',
        livereload: true
    });
})

gulp.task('js', function () {
    gulp.src('./app/js/*.js')
        .pipe(named())
        .pipe(webpackStream({
            output: {
                filename: '[name].bundle.js'
            },
            plugins: [
                new providePlugin({
                    '$': 'jquery',
                    'jQuery': 'jquery'
                })
            ],
        }))
        .pipe(gulp.dest('./app'))
        .pipe(gulpConnect.reload())
})



gulp.task('watch', function () {
    gulp.watch('./app/js/**/*.js', ['js']);
})

gulp.task('default', ['server', 'watch'])