
/* 2) Изменять картинку телефона исходя из выбранного цвета. */


let images = ['1.jpg', '11.jpg', '111.jpg'];
let currentSlide = 0;
let $sliderImage = $('.slider__image');
let $sliderControls = $('.slider__controls');
let sliderDotClass = 'slider__control';
let sliderDotAcitveClass = 'slider__control--isActive';

for (let i = 0; i < images.length; i++) {
  $sliderControls.append(`
    <div
      data-slide="${i}"
      class="${sliderDotClass}"
    >
  `);
}

let changeSlide = function() {
  $sliderImage.css('background-image', 'url(../img/' + images[currentSlide] + ')');
  $(`.${sliderDotClass}`).removeClass(sliderDotAcitveClass);
  $(`.${sliderDotClass}[data-slide="${currentSlide}"]`).addClass(sliderDotAcitveClass);
}

changeSlide();

$(`.${sliderDotClass}`).click(function() {
  currentSlide = $(this).attr('data-slide');
  changeSlide();
})