const IMAGES = ['1.jpg', '2.jpg', '3.jpg'];
let currentImg = 0;

let updateImg = function () {
    $('.slider__container').css('background-image', 'url("./img/' + IMAGES[currentImg] + '")');
    $('.slider__control').removeClass('slider__control--isActive')
    $('.slider__control[data-index="' + currentImg + '"]').addClass('slider__control--isActive')
}

for (let i = 0; i < IMAGES.length; i++) {
    $('.slider__controls').append('<div data-index="' + i + '" class="slider__control">');
}

updateImg()


$('.slider__control').click(function () {
    currentImg = $(this).attr('data-index');
    updateImg();
})