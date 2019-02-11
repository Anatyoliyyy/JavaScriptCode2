// var $ = function (selector) {
//     var elements = document.querySelectorAll(selector);
//     var foo = function (cb) {
//         for (var i = 0; i < elements.length; i++) {
//             cb(elements[i]);
//         }
//     }
//     return {
//         hide: function () {
//             foo(function (el) {
//                 el.style.display = 'none';
//             });
//         },
//         show: function () {
//             foo(function (el) {
//                 el.style.display = 'block';
//             });
//         },
//         click: function (cb) {
//             foo(function (el) {
//                 el.addEventListener('click', cb);
//             });
//         }
//     }
// }

// $('.box').hide();
// $('.box').show();

// var hide = function (selector) {
//     var elements = document.querySelectorAll(selector);
// for (var i = 0; i < elements.length; i++) {
//     elements[i].style.display = 'none';
// }
// }

// var show = function (selector) {
//     var elements = document.querySelectorAll(selector);
//     for (var i = 0; i < elements.length; i++) {
//         elements[i].style.display = 'block';
//     }
// }



$('.btn').click(function () {
    // $('.box').slideUp();
    // $('.box').slideToggle();
    // $('.box').css('display', 'block');
    $('.box').append('<div class="box2">');
})