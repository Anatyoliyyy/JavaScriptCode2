$(document).ready(function () {
    slider = $('.burger-wrapper').bxSlider({
        speed : 600, 
        slideMargin: 41
    });
    $('.burger__arrow-right').on('click', function(e){
        e.preventDefault();
        slider.goToNextSlide();
    });
    $('.burger__arrow-left').on('click', function(e){
        e.preventDefault();
        slider.goToPrevSlide();
    });
});

$('.burger__link').on('click', function(e){
    e.preventDefault();
    $('.maincontent').moveTo(7);
})
