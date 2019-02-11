// var a = 11;
// while (a < 10) {
// console.log(a);
// a++;
// }
// console.log('!!!');


// var a = 11;
// do {
//     console.log(a);
//     a++;
// } while (a < 10)
// console.log('!!!');


// for (var i = 0; i < 10; i++) {
//     console.log(i);
// }

// for (var i = 10; i > 0; i--) {
//     console.log(i);
// }


// var defaultColor = 'red';
// var color;

// while (!color || color !== defaultColor) {
//     color = prompt('COLOR ?');
// }
// alert('WIN !!!');


// var x1 = 50;
// var x2 = 100;
// var x3 = 150;
// var x;
// var prize = null;
// // while (x !== x1 && x !== x2 && x !== x3) {
// while (true) {
//     x = prompt('X?');
//     if (x === null) {
//         break;
//     }
//     if (+x === x1) {
//         prize = '111';
//         break;
//     }
//     if (+x === x2) {
//         prize = '222';
//         break;
//     }
//     if (+x === x3) {
//         prize = '333';
//         break;
//     }
// }
// if (prize) {
//     alert('WIN!!!' + prize);
// } else {
//     alert('LOOOOSER!');
// }


// var x = 0;
// while (x < 10) {
//     x++;
//     if (x === 5) {
//         continue;
//     }
//     console.log(x);
// }



// var arr = [30, 'Some string', '1', 2, 10];
// var arrPiece = ['NEW 1', 'NEW 2', 'NEW 3'];
// // var arr = new Array(6);
// // arr[0] = 1000;
// // console.log(arr[100]);
// // arr[100] = 'NEW';
// // console.log(arr[300]);

// console.log(arr);
// // console.log(arr.push('NEW'));
// // console.log(arr.push(arrPiece));
// // console.log(arr.pop());
// // console.log(arr.unshift('NEW'));
// // console.log(arr.shift());

// // var newArr = arr.concat(arrPiece);
// // console.log(newArr);

// // console.log(arr.slice(0, 2));
// // console.log(arr.splice(1, 2));
// // arr.splice(1, 0, 'NEW 1', 'NEW 2');
// // arr.splice(1, 2, 'NEW 1', 'NEW 2');
// // arr.reverse();
// // console.log(arr.sort());
// console.log(arr);


// var arr = ['NEW 1', 'NEW 2', 'NEW 3'];
// console.log(arr.join(' | '));
// document.write(arr.join());
// var x = 'sdfsdfsd, sdfsdfsdf, sdfsdfsdf, sdfsd';
// console.log(x.split(','));

// var arr = ['NEW 1', 'NEW 2', 'NEW 3'];
// for (var i = 0; i < arr.length; i++) {
//     console.log(arr[i]);
// }

// NOTES: метки


// var man = {
//     name: 'Bob',
//     age: 30
// }

// console.log(man.name);
// console.log(man.sdsdf);


// Разобраться дома, в чем отличие между получением свойства через точку и квадратные скобки
// console.log(man['name']);