const swiper = new Swiper('.sample-slider', {
  loop: true,                         //loop
  autoplay: {                         //autoplay
      delay:5000,  
  },   
  pagination: {                       //pagination(dots)
      el: '.swiper-pagination',
  },
  navigation: {                       //navigation(arrows)
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
  },
})