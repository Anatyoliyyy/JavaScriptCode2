/**
 * Класс, объекты которого описывают параметры гамбургера. 
 * 
 * @constructor
 * @param size        Размер
 * @param stuffing    Начинка
 * @throws {HamburgerException}  При неправильном использовании
 */
function Hamburger(size, stuffing) {
    this._size = size;
    this._stuffing = stuffing;
    this._toppings = [];
}

/* Размеры, виды начинок и добавок */
Hamburger.SIZE_SMALL = {
    price: 50,
    kk: 20
};
Hamburger.SIZE_LARGE = {
    price: 100,
    kk: 40
};
Hamburger.STUFFING_CHEESE = {
    price: 10,
    kk: 20
};
Hamburger.STUFFING_SALAD = {
    price: 20,
    kk: 5
};
Hamburger.STUFFING_POTATO = {
    price: 15,
    kk: 10
};
Hamburger.TOPPING_MAYO = {
    name: 'mayo',
    price: 20,
    kk: 5
};
Hamburger.TOPPING_SPICE = {
    name: 'spice',
    price: 15,
    kk: 0
};

/**
 * Добавить добавку к гамбургеру. Можно добавить несколько
 * добавок, при условии, что они разные.
 * 
 * @param topping     Тип добавки
 * @throws {HamburgerException}  При неправильном использовании
 */
Hamburger.prototype.addTopping = function (topping) {
    for (var i = 0; i < this._toppings.length; i++) {
        if (topping.name === this._toppings[i].name) {
            console.log('Такой топпинг уже есть');
            return;
        }
    }
    this._toppings.push(topping);
}

/**
 * Убрать добавку, при условии, что она ранее была 
 * добавлена.
 * 
 * @param topping   Тип добавки
 * @throws {HamburgerException}  При неправильном использовании
 */
Hamburger.prototype.removeTopping = function (topping) {
    for (var i = 0; i < this._toppings.length; i++) {
        if (topping.name === this._toppings[i].name) {
            this._toppings.splice(i, 1);
            return;
        }
    }
    console.log('Такого топпинга вообще нет');
}

/**
 * Получить список добавок.
 *
 * @return {Array} Массив добавленных добавок, содержит константы
 *                 Hamburger.TOPPING_*
 */
Hamburger.prototype.getToppings = function () {
    return this._toppings;
}

/**
 * Узнать размер гамбургера
 */
Hamburger.prototype.getSize = function () {
    return this._size;
}

/**
 * Узнать начинку гамбургера
 */
Hamburger.prototype.getStuffing = function () {
    return this._stuffing;
}

/**
 * Узнать цену гамбургера
 * @return {Number} Цена в тугриках
 */
Hamburger.prototype.calculatePrice = function () {
    var price = this._size.price + this._stuffing.price;
    for (var i = 0; i < this._toppings.length; i++) {
        price += this._toppings[i].price;
    }
    return price;
}

/**
 * Узнать калорийность
 * @return {Number} Калорийность в калориях
 */
Hamburger.prototype.calculateCalories = function () {
    var kk = this._size.kk + this._stuffing.kk;
    for (var i = 0; i < this._toppings.length; i++) {
        kk += this._toppings[i].kk;
    }
    return kk;
}





// маленький гамбургер с начинкой из сыра
var hamburger = new Hamburger(Hamburger.SIZE_SMALL, Hamburger.STUFFING_CHEESE);

// добавка из майонеза
hamburger.addTopping(Hamburger.TOPPING_MAYO);
// спросим сколько там калорий
console.log("Calories: %f", hamburger.calculateCalories());
// сколько стоит
console.log("Price: %f", hamburger.calculatePrice());
// я тут передумал и решил добавить еще приправу
hamburger.addTopping(Hamburger.TOPPING_SPICE);
// А сколько теперь стоит? 
console.log("Price with sauce: %f", hamburger.calculatePrice());
// Проверить, большой ли гамбургер? 
console.log("Is hamburger large: %s", hamburger.getSize() === Hamburger.SIZE_LARGE); // -> false
// Убрать добавку
hamburger.removeTopping(Hamburger.TOPPING_SPICE);
console.log("Have %d toppings", hamburger.getToppings().length); // 1