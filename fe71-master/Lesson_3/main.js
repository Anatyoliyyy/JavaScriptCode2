// var f1 = function (a, b) {
//     console.log(a + b);
// }

// function f1(a, b) {
//     console.log(a + b);
// }

// f1(100, 30)
// f1(140, 390)



// var sum = function (a, b) {
//     return a + b;
// }

// console.log(sum(10, 30));
// alert(sum(100, 40))



// if (false) {
//     var x = 10;
// }
// console.log(x + 'sdfsd');


// var f1 = function () {
//     var a = 10;
// }
// f1()

// console.log(a);

// var newA = 10;
// (function (a) {
//     var x = 10;
//     console.log(x + a);
// }(newA))


// var map = function (array, func) {
//     var res = [];
//     for (var i = 0; i < array.length; i++) {
//         res.push(func(array[i]));
//     }
//     return res;
// }




// var arr = [4, 6, 10, 90, 56];
// var f1 = function (x) {
//     return x * 2;
// }
// var f2 = function (x) {
//     return x / 2;
// }
// console.log(map(arr, f1)); // [8, 12, 20, 180, 112];
// console.log(map(arr, f2)); // [2, 3, 5, 45, 28];



// var greet = function (x, y) {
//     return x + " " + y + " Hello! I'm " + this.name;
// }

// var man = {
//     name: 'Bob',
//     greet: greet
// }

// var man2 = {
//     name: 'Ivan',
//     greet: greet
// }

// console.log(man.greet.call(man2, 10, 40));
// console.log(man.greet.apply(man2, [10, 300]));
// console.log(man2.greet(10, 90));


// var params = [30, 40];

// var sum = function (a, b) {
//     return a + b;
// }

// console.log(sum(params));
// console.log(sum(params[0], params[1]));