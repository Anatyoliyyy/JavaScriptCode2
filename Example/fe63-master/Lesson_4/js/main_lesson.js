// var f2 = function () {
//     var a = 10;
//     return function () {
//         a++;
//         return a;
//     }
// }

// var f1 = f2();

// console.log(f1());
// console.log(f1());
// console.log(f1());
// console.log(f1());



// var generator = function (start, step) {
//     return function () {
//         return start += step;
//     }
// }

// var f1 = generator(10, 5);
// var f2 = generator(1, 3);


// var take = function (fn, n) {
//     var resArr = [];
//     for (var i = 0; i < n; i++) {
//         resArr.push(fn());
//     }
//     return resArr;
// }

// console.log(take(f1, 5));
// console.log(take(f2, 10));



// ;
// (function () {
//     var a = 10;
//     console.log(a);
// }());