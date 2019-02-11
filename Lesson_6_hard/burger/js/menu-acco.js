let vacc = document.querySelector('.variety-acco'),
    vlist = vacc.children
vacc.addEventListener('click', function (event) {
    let target = event.target
    if (!target.classList.contains('variety-acco__trigger')) {
        return
    }
    event.preventDefault()
    target = target.parentNode.parentNode
    if (target.classList.contains('variety-acco__items--active')) {
        target.classList.remove('variety-acco__items--active')
        return
    } else {
        for (var i = 0; i < vlist.length; i++) {
            vlist[i].classList.remove('variety-acco__items--active')
            target.classList.add('variety-acco__items--active')
        }
    }
})