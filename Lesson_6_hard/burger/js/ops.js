$(document).ready(function () {
    $(".maincontent").onepage_scroll({
        sectionContainer: ".section",
        easing: "ease-in-out",
        animationTime: 1000,
        
        loop: false,
        pagination: false,
        updateURL: false,
        keyboard: true,
        responsiveFallback: false,
        direction: "vertical"
    });
    $('.page1').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(1);
    });
    $('.page2').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(2);
    });
    $('.page3').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(3);
    });
    $('.page4').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(4);
    });
    $('.page5').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(5);
    });
    $('.page6').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(6);
    });
    $('.page7').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(7);
    });
    $('.page8').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveTo(8);
    });
    $('.arrow__link').on('click', function(e){
        e.preventDefault();
        $(".maincontent").moveDown();
    });
});

