




$(function() {
    $("[data-fancybox]").fancybox({
        margin : [100, 0],
    });
    $('.popup__link-button').on('click', e => {
        e.preventDefault()
        $.fancybox.close();
    });
});



