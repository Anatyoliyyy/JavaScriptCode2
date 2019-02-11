$(document).ready(function () {


    $('.acc-body').hide();

    $('.acc-head').click(function(){

        var find = $(this).next('.acc-body');
        var acc = $(this).closest('#accordeon');

        if(find.is(':visible')){
           find.slideUp();
        }
        else{
            acc.find('>.acc-body').slideUp();
            find.slideDown();
        }
    })
});   
