

/* HW 6
Создать класс бургер. При инициализации класса (при создании экземпляра этого класса) передавать размер 
и тип котлеты. Добавить методы по работе с соусами. Должен быть метод для добавления УНИКАЛЬНОГО соуса и для его удаления. */

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
            alert("Your sauce is not unique!");
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

// for cheeseburger
let cheeseburger = new Burger("Big", "Turkey");
alert(cheeseburger.type + " " + cheeseburger.size);

// add souces
cheeseburger.addSouce("Guacamole");
cheeseburger.addSouce("Ranche");
cheeseburger.addSouce("Big-Mak");


// delete last souce
cheeseburger.deleteSouce();

//________________________________________________________//

// for hamburger
let hamburger = new Burger("Middle", "Veal");
alert(hamburger.type + " " + hamburger.size);

// add souces
hamburger.addSouce("Big-Mak");
hamburger.addSouce("Ranche");
hamburger.addSouce("Ranche");

// delete last souce
hamburger.deleteSouce();


