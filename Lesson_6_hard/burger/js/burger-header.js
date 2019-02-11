let menu = (function(options) {
    
      let button = document.querySelector(options.button);
      let menu = document.querySelector(options.menu);
      let body = document.querySelector('body');
    
      let _toggleMenu = function(e) {
        button.classList.toggle('header__burger-btn--active');
        menu.classList.toggle('overlay--active');
        body.classList.toggle('body--active');
        
      }
    
      let addListeners = function() {
        button.addEventListener('click', _toggleMenu);
      }
    
      return {
        init: addListeners
      };
    })({
      button: '#toggle',
      menu: '#overlay'
    });
  
    
    menu.init();

    $('.overlay-menu__link').on('click', function(e){  
      e.preventDefault();
       $('.overlay').removeClass('overlay--active');    
     });

     $('.order-link').on('click', function(e) {
      e.preventDefault();
      $('.maincontent').moveTo(7);
     });
    
    // $('#toggle').click(function() {
    //   $(this).toggleClass('button_container--active');
    //   $('#overlay').toggleClass('overlay--open');
    //   $('body').toggleClass('body-active-menu');
    // });
    