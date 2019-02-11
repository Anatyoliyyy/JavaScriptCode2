class Burger {
  constructor(size, type) {
    this.souces = [];
    this.size = size;
    this.type = type;
  }
}

Burger.prototype.addSouce = function(souce){
    let succes = true;
    for (let i = 0; i < this.souces.length; i++) {
        if(this.souces[i] === souce){
            alert("Ваш соус не уникальный!");
            succes = false;
        }
    }
    if(succes){
    this.souce = this.souces.push(souce);
    alert(this.souces);
    }
}

Burger.prototype.deleteSouce = function(souce){
    this.souce = this.souces.splice(-1,1);
    alert(this.souces);
}

// for hamburger
let hamburger = new Burger("Middle", "Beef");
alert(hamburger.type + " " + hamburger.size);

// add souces
hamburger.addSouce("Ketchup");
hamburger.addSouce("Mayoneze");
hamburger.addSouce("Mayoneze");

// delete last souce
hamburger.deleteSouce();


// for cheeseburger
let cheeseburger = new Burger("Small", "Pork");
alert(cheeseburger.type + " " + cheeseburger.size);

// add souces
cheeseburger.addSouce("Gorchitsa");
cheeseburger.addSouce("Mayoneze");
cheeseburger.addSouce("Ketchup");

// delete last souce
cheeseburger.deleteSouce();