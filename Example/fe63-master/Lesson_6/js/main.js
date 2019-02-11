// var greet = function (greetWord, age) {
//     return greetWord + " My name is " + this.name + '. I am ' + age;
// }

// var man = {
//     name: 'Bob',
//     greet: greet
// }

// var man2 = {
//     name: 'Ivan',
//     greet: greet
// }

// console.log(man.greet('Hello!', 40));
// console.log(man2.greet.call(man, 'Hi!', 30));
// console.log(man2.greet.apply(man, ['Hi!', 25]));


// var params = [2, 5, 10];
// var sum = function (a, b, c) {
//     return a + b + c;
// }
// console.log(sum(...params));



var Car = function (make, model) {
    this.make = make;
    this.model = model;
}

Car.prototype.engine = function () {
    return 'ВРУМ ВРУМ! ' + this.model;
}


var car1 = new Car("Audi", "rs6");
// car1.__proto__ = vehicle;
var car2 = new Car("BMW", "M5");
// car2.__proto__ = vehicle;
var car3 = new Car("Honda", "Accord");
// car3.__proto__ = vehicle;

console.log(car1);
console.log(car1.engine());
console.log(car2);
console.log(car2.engine());