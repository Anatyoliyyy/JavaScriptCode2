let boxes = document.querySelector('.box');


let amount = 10;
let area = new Array(amount);

for (let i = 0; i < area.length; i++) {
  area[i] = new Array(amount);
    for (let j = 0; j < area[i].length; j++) {  
      let r = document.createElement('div');
      r.className = 'text';
      document.body.appendChild(boxes);
      boxes.appendChild(r);
  }
}

let click = function(e){
let box = this;
  let x = e.offsetX;
  let y = e.offsetY;
  alert("X : " + x + ' ' + "Y : " + y);
}
boxes.addEventListener('click' , click);

for ( const a of boxes){
r.addEventListener('click', click);
}