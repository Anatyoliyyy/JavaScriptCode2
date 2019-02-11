// var boxes = document.getElementsByTagName("div");
// var boxes = document.getElementsByClassName("box");
// var box = document.getElementById("box1");
// console.log(box2.className);

// var boxes = document.querySelectorAll('div.box');
// var box = document.querySelector('div.box');
// console.log(box);

// box1.innerText = 'sdfsdfsfsfsdf';

// function clickHandler() {
//     alert('clickHandler');
// }



// box3.onclick = function () {
//     alert('111111');
// }
// box3.onclick = function () {
//     alert('222222');
// }


// box3.addEventListener('click', function () {
//     alert('!!!!!!!!!');
// })
// box3.addEventListener('click', function () {
//     alert('dddddd');
// })





function clickHandler(e) {
    var target = e.target;
    var x = e.offsetX;
    var y = e.offsetY;
    var newCircle = document.createElement('div');
    newCircle.className = 'circle';
    newCircle.style.left = x + 'px';
    newCircle.style.top = y + 'px';
    target.appendChild(newCircle);
}


var area = document.querySelector('#area');
area.addEventListener('click', clickHandler)


var APP = (function () {
    var getDataFromServer = function () {

    }
    return {
        init: function () {
            getDataFromServer()
        },


    }

}())

APP.init()