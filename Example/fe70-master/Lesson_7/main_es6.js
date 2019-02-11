// if (true) {
//     let a = 10;
// }
// console.log(a);

// console.log(a);
// let a = 10;


// const CONSTANT1 = 10;
// CONSTANT1 = 20;

// var x = 10;
// var box1 = `
//     <div>
//         ${x}
//     </div>
// `;

// var x = 10;
// var z = 20;

// var y = {
//     x,
//     z
// }


// var params = [10, 40, 50];
// var foo = function (a, b, c) {
//     console.log(a + b + c);
// }
// foo(...params)

// var man = {
//     name: 'Bob',
//     age: 20
// }

// var man2 = {
//     ...man,
//     name: 'Ivan',
//     email: 'man@gmail.com'
// }

// console.log(man);
// console.log(man2);

//SPREAD
// var arr = [1, 5, 6];
// arr = arr.concat(10);
// arr = [...arr, 10];



// var greet = function (a, b) {
//     return this.name + ' ' + (a + b)
// }

// var man1 = {
//     name: 'bob',
//     greet: greet
// }

// var man2 = {
//     name: 'ivan',
//     greet: greet
// }

// console.log(man1.greet.call(man2, 30, 60));
// console.log(man2.greet.apply(man1, [30, 60]));



// var arr = [4, 5, 7];

// console.log(arr.map((a) => a * 2));

// for (const a of arr) {
//     console.log(a);
//     console.log(a);
//     console.log(a);
//     console.log(a);
// }

// for (let i = 0; i < arr.length; i++) {
//     console.log(array[i]);
// }

// arr.forEach((i) => console.log(i))


var men = [{
        name: 'Bob',
        age: 43
    },
    {
        name: 'Ivan',
        age: 50
    },
    {
        name: 'Kate',
        age: 20
    },
    {
        name: 'John',
        age: 35
    }
]

console.log(men.filter((m) => m.age > 40).map((fm) => fm = { ...fm,
    name: `Mr. ${fm.name}`
}));