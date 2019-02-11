class BurgerModel {
  constructor() {
    this._sizes = [{
        id: 'size_small',
        name: 'Small',
        price: 40,
        isChosen: false
      },
      {
        id: 'size_medium',
        name: 'Medium',
        price: 50,
        isChosen: false
      },
      {
        id: 'size_large',
        name: 'Large',
        price: 60,
        isChosen: false
      }
    ]
    this._stuffings = [{
        id: 'stuffing_meat',
        name: 'Meat',
        price: 70,
        isChosen: false
      },
      {
        id: 'stuffing_potato',
        name: 'Potato',
        price: 50,
        isChosen: false
      },
      {
        id: 'stuffing_salad',
        name: 'Salad',
        price: 30,
        isChosen: false
      }
    ]
    this._toppings = [{
        id: 'topping_pepper',
        name: 'Pepper',
        price: 10
      },
      {
        id: 'topping_cheese',
        name: 'Cheese',
        price: 20
      },
      {
        id: 'topping_bbq',
        name: 'Bbq ',
        price: 20
      },
      {
        id: 'topping_mayo',
        name: 'Mayo',
        price: 10
      }
    ]
    this._chosenSize = this._sizes[1].id;
    this._chosenStuffing = this._stuffings[0].id;
    this._chosentoppings = this._toppings[2].id;
  }

  // get sizes() {
  //   return this._sizes;
  // }

  getSizes(cb) {
    // getting sizes from the server ...
    cb(this._sizes);
  }

  getStuffings(cb) {
    // getting stuffings from the server ...
    cb(this._stuffings);
  }

  getToppings(cb){
    cb(this._toppings);
  }

  getBurgerData(cb) {
    let burgerData = {
      size: this._sizes.find(s => s.id === this._chosenSize),
      stuffing: this._stuffings.find(s => s.id === this._chosenStuffing),
      topping: this._toppings.find(s => s.id === this._chosentoppings)
    }
    if (cb) {
      cb(burgerData);
    }
    return burgerData;
  }

}