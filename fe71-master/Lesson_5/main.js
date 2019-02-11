// let btns = document.getElementsByTagName('button');
// let btns = document.getElementsByClassName('btn');
// let btn = document.getElementById('btn1');
// console.dir(btn);

// let btns = document.querySelectorAll('#btn1');
// let btn = document.querySelector('.btn');
// console.log(btn);


// let btns = document.querySelectorAll('button');

// // for (const btn of btns) {
// // }

// for (let i = 0; i < btns.length; i++) {
//   let newI = i + 1;
//   btns[i].innerText += " " + newI
// }


// let btn = document.querySelector('#btn1');
// btn.onclick = function() {
//   alert('111111');
// }

// btn.onclick = function() {
//   alert('2222222');
// }

// btn.addEventListener('click', function() {
//   alert('1111111');
// })

// btn.addEventListener('click', function() {
//   alert('2222222');
// })


// let areas = document.querySelectorAll('.area');

// let clickHandler = function(event) {
//   //   console.log(event.offsetX);
//   //   console.log(event.offsetY);
//   let area = this;
//   let x = event.offsetX;
//   let y = event.offsetY;
//   let el = document.createElement('div');
//   el.className = 'square';
//   el.style.top = y + 'px';
//   el.style.left = x + 'px';
//   area.appendChild(el);
//   console.dir(x);
// }

// for (const a of areas) {
//   a.addEventListener('click', clickHandler)
// }


// let amount = 10;
// let area = new Array(amount);

// for (let i = 0; i < area.length; i++) {
//   area[i] = new Array(amount);
//   for (let j = 0; j < area[i].length; j++) {
//     area[i][j] = i + ' ' + j;
//   }
// }
// console.log(area);