
/* 1) напишите функцию take(gen, x) которая вызвает функцию gen заданное число (x) раз и возвращает массив с результатами вызовов.
var gen2 = sequence(0, 2);
console.log(take(gen2, 5)); // [0, 2, 4, 6, 8 ]
2) напиши функцию pluck, которая берет массив объектов и возвращает массив значений определенного поля:
var characters = [
 { 'name': 'barney', 'age': 36 },
 { 'name': 'fred', 'age': 40 }
];
Первая задача к тому, что делали на занятии относится
Мы делали такой генератор */


// Task #1
var generator = function (start, step) {
    start -= step;
    return function () {
       return start += step;
    }
}
var f1 = generator(0, 2);


var take = function (gen, x) {
    var res = [];
    for (var i = 0; i < x; i++) {
        res.push(gen());
    }
    return res;
}

console.log(take(f1, 5));





// Task #2
let characters = [{ 
    'name': 'barney', 
    'age': 36 
},
{ 
    'name': 'fred', 
    'age': 40 
},
{ 
    'name': 'teiylor', 
    'age': 25
},
{ 
    'name': 'stiv', 
    'age': 30
}];

function pluck(arr, prop) {
    let k = arr.map(function(el){
        return el[prop];
    });
    return k;
}

console.log(pluck(characters, 'name'));