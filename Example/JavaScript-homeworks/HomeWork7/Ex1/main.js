$('#accordeon .acc-head').on('click', show_hide);
function show_hide(){
if($(this).hasClass('.acc-body'))
    {
      $(this).removeClass('.acc-body');
      $(this).next().slideUp("slow");
    }
    else
    {
    $('#accordeon .acc-body').slideUp("slow");
    $('.acc-head').removeClass('.acc-body');
    $(this).addClass('.acc-body');
    $(this).next().slideDown("slow");
    }
}