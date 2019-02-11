// var f1 = function (start, step) {
//     var a = start;
//     return function () {
//         return a += step;
//     }
// }

// var f2 = f1(10, 2); // 'a' is here !
// var f3 = f1(5, 5); // 'a' is here !
// console.log(f2());
// console.log(f2());
// console.log(f3());
// console.log(f3());
// console.log(f3());
// console.log(f2());
// console.log(f2());
// console.log(f2());

// console.log(f1(10)());
// console.log(f1(10)());
// console.log(f1(10)());
// console.log(f1(10)());


// if (true) {
//     let a = 10;
// }
// console.log(a);

// console.log(a);
// let a = 10

// const CONSTANT = 10;
// CONSTANT = 20;

// const CONSTANT = {
//     x: 10
// };
// CONSTANT.x = 20;
// console.log(CONSTANT);


// let f1 = function (a = 0, b = 0) {
//     return a + b;
// }
// console.log(f1());


// let img = '1.jpg';
// document.write(`
//     <div>
//         <img src="${img}">
//     </div>
// `);


// var x = 10;
// var y = 20;
// var z = {
//     x,
//     y
// }


// var params = [14, 60, 78];
// var sum = function (a, b, c) {
//     return a + b + c;
// }

// console.log(sum(...params));



// var man = {
//     name: 'Bob'
// }

// var man2 = {
//     name: 'Ivan',
//     age: 30
// }

// var man3 = {
//     ...man,
//     ...man2
// }

// console.log(man3);



// var f1 = function (a, cb) {
//     let b = a * 2;
//     cb();
// }

// f1(10, _ => {
//     console.log('!!!!')
// })


// function () {
//     2 + 2;
//     return 10;
// }

// _ => 10;