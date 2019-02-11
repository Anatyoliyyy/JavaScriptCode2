let areas = document.querySelectorAll('.square');
let amount = 10;
let area = new Array(amount);
let field = this;
for (let i = 0; i < area.length; i++) {
  area[i] = new Array(amount);
  for (let j = 0; j < area[i].length; j++) {
    area[i][j] = i + ' ' + j;
    area[i][j] = document.createElement('div');
    area[i][j].className = 'square';
    fill.appendChild(area[i][j]);
    area[i][j].dataset.index = '[' + i + ']'+'[' + j + ']';
  }
}
console.log(area);

let clickHandler = function(event) {
  // let box = getElementByClassName('square');
  // alert(box.getAttribute('data-index'));
}


for (const a of areas) {
  a.addEventListener('click', clickHandler)
}