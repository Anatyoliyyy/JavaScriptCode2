let areas = document.querySelectorAll('.area');
let size = document.querySelector('.number').value;
let clickHandler = function(event) {
  let area = this;
  let x = event.offsetX;
  let y = event.offsetY;
  let el = document.createElement('div');
  el.className = 'square';
  el.style.top = y + 'px';
  el.style.left = x + 'px';
  if(document.querySelector('.number').value > 300){
    alert('Размер выходит за грани контейнера!');
  }
  else{
    el.style.width = document.querySelector('.number').value + 'px';
    el.style.height = el.style.width;
  }
  area.appendChild(el);
  console.dir(x + ' ' + y);
}

for (const a of areas) {
  a.addEventListener('click', clickHandler)
}

