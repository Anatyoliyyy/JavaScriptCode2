(function () {

    // var btns = document.getElementsByTagName('button');
    // var btns = document.getElementsByClassName('btn');
    // console.log(btns);

    // var btn = document.getElementById('btn1');
    // console.log(btn);

    // console.log(btn1);

    // var btn = document.querySelector('.box .btn');
    // console.log(btn);
    // var btns = document.querySelectorAll('.box .btn');
    // console.log(btns);

    // area.onclick = function () {
    //     console.log('111');
    // }

    // area.onclick = function () {
    // console.log('222');
    // }

    // area.addEventListener('click', function () {
    //     console.log('111');
    // })

    // area.addEventListener('click', function () {
    //     console.log('222');
    // })

    // area.addEventListener('click', function (e) {
    //     console.log(e);
    // })

    // area.style.backgroundColor = 'gold';

    // area.className += ' newClass';
    // area.classList.add('newClass');

    area.addEventListener('click', function (e) {
        var el = document.createElement('div');
        // var target = this;
        var target = e.target;
        var color = newColor.value;
        el.classList.add('figure');
        el.style.top = e.offsetY + 'px';
        el.style.left = e.offsetX + 'px';
        el.style.backgroundColor = color;
        var figureInput = document.querySelectorAll('[name="figure"]');
        for (var i = 0; i < figureInput.length; i++) {
            if (figureInput[i].checked) {
                el.classList.add(figureInput[i].value);
            }
        }
        target.appendChild(el);

    })

}());