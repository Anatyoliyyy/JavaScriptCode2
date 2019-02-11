



let acc = document.querySelector('.team-acco'),
    list = acc.children

acc.addEventListener('click', function (event) {
    let target = event.target
    if (!target.classList.contains('team-acco__trigger')) {
        return
    }
    event.preventDefault()
    target = target.parentNode
    if (target.classList.contains('team-acco__item--active')) {
        target.classList.remove('team-acco__item--active')
        return
    } else {
        for (var i = 0; i < list.length; i++) {
            list[i].classList.remove('team-acco__item--active')
            target.classList.add('team-acco__item--active')
        }
    }
})