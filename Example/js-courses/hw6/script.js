
class Burger {
  constructor(size, type_cutlet) {
    this.size = size;
    this.type_cutlet = type_cutlet;
    this._souce = [];
  }

  addSouce(souce){
    let a = false;
    for (let i = 0; i < this._souce.length; i++) {
      if(this._souce[i] === souce){
        console.log("Этот соус уже есть");
        a = true;
        }
      }
      if(!a){
        this.souce = this._souce.push(souce);
        console.log("Souce: " + this._souce);
      }
    
  }

  deleteSouce(arr){
    this.souce = delete this._souce[arr];
    console.log("Souce: " + this._souce);
  }

  get fullBurger(){
    return `${"Size: " + this.size} ${"\nType: " + this.type_cutlet}`;
  }

  set fullBurger(newValue){
    [this.size, this.type_cutlet] = newValue.split(' ');
  }
}



let burger = new Burger("большой", "говядина");
console.log(burger.fullBurger);
burger.addSouce("сырный");
burger.addSouce("кетчуп");
burger.addSouce("сырный");
burger.deleteSouce(1);
burger.fullBurger = "средний телятина";
console.log(burger.fullBurger);






