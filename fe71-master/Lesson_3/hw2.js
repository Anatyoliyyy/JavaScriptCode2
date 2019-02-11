// var memories = [{
//         val: 64,
//         price: 400
//     },
//     {
//         val: 128,
//         price: 600
//     },
//     {
//         val: 256,
//         price: 800
//     }
// ]

// var colors = [{
//         name: 'black',
//         img: 'black1.png',
//         k: 15
//     },
//     {
//         name: 'gold',
//         img: 'gold.png',
//         k: 10
//     },
//     {
//         name: 'silver',
//         img: 'silver.png',
//         k: 0
//     }
// ]

// var price = 0;
// var img = null;
// var isCancelled = false;
// var memory, color;


// memory: while (true) {
//     memory = prompt('Memory ?');
//     if (memory === null) {
//         isCancelled = true;
//         break;
//     }
//     for (var i = 0; i < memories.length; i++) {
//         if (memories[i].val === +memory) {
//             price = memories[i].price;
//             break memory;
//         }
//     }
// }

// color: while (price) {
//     color = prompt('Color ?');
//     if (color === null) {
//         // isCancelled = true;
//         break;
//     }
//     for (var i = 0; i < colors.length; i++) {
//         if (colors[i].name === color) {
//             img = colors[i].img;
//             price += colors[i].k;
//             break color;
//         }
//     }
// }

// var renderResult = function () {
//     if (isCancelled) {
//         document.write('<h1>ПОКА!</h1>')
//     }
//     if (price && img) {
//         document.write('<h1>Price: ' + price + '$</h1><img width="200" src="../img/' + img + '">')
//     }
//     if (price && !img) {
//         document.write('<h1>ПОКА!</h1><h2>Price: ' + price + '$</h2>')
//     }
// }

// renderResult();

// // if (isCancelled) {
// //     document.write('<h1>ПОКА!</h1>')
// // } else {
// //     document.write('<h1>Price: ' + price + '$</h1><img width="200" src="../img/' + img + '">')
// // }