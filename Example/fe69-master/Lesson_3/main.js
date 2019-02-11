// f1()
// var f1 = function () {
//     console.log('111');
// }

// f2()
// function f2() {
//     console.log('222');
// }

// var sum = function (a, b) {
//     a + b;
//     // return a + b;
// }
// console.log(sum(10, 30));
// console.log(sum(100, 320));

// var f2 = function () {
//     var a = 0;
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
//     if (!start) start = 0;
//     if (!step) step = 1;
//     start -= step;
//     return function () {
//         return start += step;
//     }
// }
// var g1 = generator(3, 5);
// var g2 = generator(1, 7);


// var take = function (gen, num) {
//     var res = [];
//     for (var i = 0; i < num; i++) {
//         res.push(gen());
//     }
//     return res;
// }

// console.log(take(g1, 10));
// console.log(take(g2, 8));



// ;
// (function (a) {
//     var x = 10;
//     console.log(x);
// }(10));


// var greet = function (a, b) {
//     return "Hello! I'm " + this.name + ". " + a + b;
// }

// var man = {
//     name: 'Bob',
//     greet: greet
// }

// var man2 = {
//     name: 'Ivan',
//     greet: greet
// }


// console.log(man.greet('! ', '!'));
// console.log(man2.greet('| ', '|'));
// console.log('__________');
// console.log(man2.greet.call(man, '***', '***'));
// var params = ['***', '!!!'];
// console.log(man2.greet.apply(man, params));


// var sum = function (a, b) {
//     return a + b;
// }

// var params = [30, 60];
// console.log(sum(...params));

// var man = {
//     name: 'Bob',
//     age: 40
// }

// var man2 = {
//     ...man,
//     age: 50
// }

// console.log(man2);