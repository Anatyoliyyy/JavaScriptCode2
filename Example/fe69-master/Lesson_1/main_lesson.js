// alert('Hello JS');
// document.write('<h1>Hello JS</h1>');
// console.log('Hello JS');


// var x = 10;
// var x = 'Hello JS';
// var x = true;
// var x;
// var x = null;
// var x = {};

// var x = function () {}

// console.log(x);
// console.log(typeof x);


// var a = 20;
// var b = '10';
// console.log(a - b);

// var a = 20;
// var b = 'kjhgjkhl';
// console.log(a + +b);


// var a = 10;
// console.log(a);
// console.log(a++);
// console.log(++a);
// console.log(a--);
// console.log(--a);
// console.log(a);

// var a = '10';
// var b = '2';

// console.log(a === b);
// console.log(a < b);
// console.log(a <= b);
// console.log(a > b);

// console.log(true && false);
// console.log(false || false);

// var age = 91;
// if (age > 90) {
//     console.log('Лучше кефир =(');
// } else if (age < 18) {
//     console.log('Приходи с папой');
// } else {
//     console.log('Держи пиво');
// }
// console.log('!!!');

// false - false, 0, null, undefined, NaN, '';


// var c = confirm('Точно???');
// console.log(c);

// var c = prompt('Сколько лет ?');
// console.log(+c);





// HW 1 ( isNaN )
// var age = prompt('Сколько лет ?');

// if (age !== null) {
//     if (+age > 90) {
//         console.log('Лучше кефир =(');
//     } else if (+age < 18) {
//         console.log('Приходи с папой');
//     } else {
//         console.log('Держи пиво');
//     }
// } else {
//     console.log('ОК. Пока');
// }
// console.log('!!!');


var memory = prompt('Memory?');
var price = 0;
var isCorrect = true;
if (memory === null) {
    isCorrect = false;
    document.write('<h2>Пока</h2>');
} else {
    if (+memory === 128) {
        price = 500;
    } else if (+memory === 256) {
        price = 700;
    } else if (+memory === 512) {
        price = 900;
    } else {
        isCorrect = false;
        document.write('<h2>Такой памяти нет</h2>');
    }
}


if (isCorrect) {
    document.write('<h1>Price: ' + price + '$</h1>');
}