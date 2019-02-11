var compareObjects = function (o1, o2, key) {
    if (!key) key = 'name';
    return o1[key] === o2[key] ? true : false;
}

// CONSTANTS
var SIZES = [{
        name: 'small',
        price: 50,
        kk: 20
    },
    {
        name: 'large',
        price: 100,
        kk: 40
    }
];
var STUFFING_CHEESE = {
    name: 'cheese',
    price: 10,
    kk: 20
};
var STUFFING_POTATO = {
    name: 'potato',
    price: 15,
    kk: 10
};
var STUFFING_SALAD = {
    name: 'salad',
    price: 20,
    kk: 5
};
var TOPPING_SPICE = {
    name: 'spice',
    price: 15,
    kk: 0
};
var TOPPING_MAYO = {
    name: 'mayo',
    price: 20,
    kk: 5
};
// !!!!!!!!!

var Hamburger = function () {
    this._size = null;
    this._stuffing = null;
    this._toppings = [];
}

Hamburger.prototype.changeSize = function (size) {
    return this._size = size;
}

Hamburger.prototype.getSize = function () {
    return this._size;
}

Hamburger.prototype.changeStuffing = function (stuffing) {
    return this._stuffing = stuffing;
}

Hamburger.prototype.getStuffing = function () {
    return this._stuffing.name;
}

Hamburger.prototype.getToppings = function () {
    return this._toppings;
}

Hamburger.prototype.addTopping = function (newTopping) {
    for (var i = 0; i < this._toppings.length; i++) {
        if (compareObjects(newTopping, this._toppings[i])) {
            console.log('Такой топпинг уже есть');
            return false;
        }
    }
    this._toppings.push(newTopping);
    return newTopping;
}

Hamburger.prototype.removeTopping = function (newTopping) {
    for (var i = 0; i < this._toppings.length; i++) {
        if (compareObjects(newTopping, this._toppings[i])) {
            this._toppings.splice(i, 1);
            return newTopping;
        }
    }
    console.log('Такого топпинга вообще нет');
    return false;
}

Hamburger.prototype.calculatePrice = function () {
    var price = this._size.price + this._stuffing.price;
    for (var i = 0; i < this._toppings.length; i++) {
        price += this._toppings[i].price;
    }
    return price;
}

Hamburger.prototype.calculateKk = function () {
    var kk = this._size.kk + this._stuffing.kk;
    for (var i = 0; i < this._toppings.length; i++) {
        kk += this._toppings[i].kk;
    }
    return kk;
}

// var burger1 = new Hamburger(SIZE_LARGE, STUFFING_CHEESE);

// console.log(burger1.getSize());
// console.log(burger1.getStuffing());
// console.log('______________');
// console.log(burger1.addTopping(TOPPING_MAYO));
// console.log(burger1.addTopping(TOPPING_MAYO));
// console.log(burger1.addTopping(TOPPING_SPICE));
// console.log(burger1.getToppings());
// console.log(burger1.removeTopping(TOPPING_SPICE));
// console.log(burger1.removeTopping(TOPPING_SPICE));
// console.log(burger1.getToppings());
// console.log('______________');
// console.log(burger1.calculatePrice());
// console.log(burger1.calculateKk());


// var burger2 = new Hamburger();

// var sizes = document.querySelectorAll('input[name="size"]');
// for (var i = 0; i < sizes.length; i++) {
//     sizes[i].addEventListener('change', function () {
//         var name = this.value;
//         var size = null;
//         for (var i = 0; i < SIZES.length; i++) {
//             if (SIZES[i].name === name) {
//                 size = SIZES[i];
//             }
//         }
//         burger2.changeSize(size);
//         console.log(burger2.getSize());
//     })
// }