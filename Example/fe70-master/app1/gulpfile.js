const gulp = require('gulp');
const connect = require('gulp-connect');
const sass = require('gulp-sass');
const webpack = require('webpack-stream');

gulp.task('server', function () {
    connect.server({
        root: 'dist',
        livereload: true
    })
})

gulp.task('js', function () {
    gulp.src('./src/js/app.js')
        .pipe(webpack({
            output: {
                filename: 'app.bundle.js',
            },
        }))
        .pipe(gulp.dest('./dist/js'))
        .pipe(connect.reload())
})

gulp.task('styles', function () {
    gulp.src('./src/scss/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest('./dist/css'))
        .pipe(connect.reload())
})

gulp.task('html', function () {
    gulp.src('./src/*.html')
        .pipe(gulp.dest('./dist'))
        .pipe(connect.reload())
})

gulp.task('watch', function () {
    gulp.watch('./src/scss/**/*.scss', ['styles'])
    gulp.watch('./src/*.html', ['html'])
    gulp.watch('./src/js/**/*.js', ['js'])
})

gulp.task('default', ['watch', 'server'])