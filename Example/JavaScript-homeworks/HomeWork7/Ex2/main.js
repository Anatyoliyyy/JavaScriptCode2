let images = ['black.png', 'gold.png', 'silver.png'];
let currentSlide = 0;
let $sliderImage = $('.slider__image');
let $sliderControls = $('.slider__controls');
let sliderDotClass = 'slider__control';
let sliderDotAcitveClass = 'slider__control--isActive';
let sliderColor = '.slider__Control-Color';

for (let i = 0; i < images.length; i++) {
  $sliderControls.append(`
    <div
      data-slide="${i}"
      class="${sliderDotClass}"
    >
  `);

  $(`.${sliderDotClass}[data-slide="${i}"]`).css("background-color", function(){

    switch($(this).data("slide")) {
      case 0:  
      return "#34353A";
      break;
    
      case 1:  
      return "#FDE3CC";
      break;

      case 2:
      return "#E3E3E1";
      break;
    }
      });
}

let changeSlide = function() {
  $sliderImage.css('background-image', 'url(img/' + images[currentSlide] + ')');

  $(`.${sliderDotClass}`).removeClass(sliderDotAcitveClass);
  $(`.${sliderDotClass}[data-slide="${currentSlide}"]`).addClass(sliderDotAcitveClass);
}
changeSlide();

$(`.${sliderDotClass}`).click(function() {
  currentSlide = $(this).attr('data-slide');
  changeSlide();
})