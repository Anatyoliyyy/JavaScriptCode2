let areas = document.querySelectorAll('.area');
let widthArea1 = document.getElementById('area-1');
let widthArea2 = document.getElementById('area-2');
let newParams = prompt("Ширина / Высота ?");
let err = false;
  if (+newParams >= widthArea1.offsetWidth){
    err = true;
}
else if (+newParams >= widthArea2.offsetWidth){
    err = true;
}

let clickHandler = function(event) {
  //   console.log(event.offsetX);
  //   console.log(event.offsetY);
  let area = this;

  let x = event.offsetX;
  let y = event.offsetY;
  let el = document.createElement('div');
  el.className = 'square';
  el.style.top = y + 'px';
  el.style.left = x + 'px';
  area.appendChild(el);
  console.dir(x);
  el.style.width = newParams + 'px';
  el.style.height = newParams + 'px';
}
if(!err){
for (const a of areas) {
  a.addEventListener('click', clickHandler)
}
}
else{
    console.log("Error");
}



