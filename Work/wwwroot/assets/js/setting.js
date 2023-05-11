$(document).ready(function(){
    
  $('.menu').on('click', function() {
  $('.bar').toggleClass('animate');
      $('.expand-menu').toggleClass('animate');
      $('.expand-menu .nav-link').toggleClass('animate');
      setTimeout(function(){
          $('.expand-menu .nav-link').toggleClass('animate-show');
      },500)
})
  
})

var btns = document.querySelectorAll(".nav-link");
console.log(btns);

// Loop through the buttons and add the active class to the current/clicked button
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function() {
    var current = document.getElementsByClassName("active");
    current[0].className = current[0].className.replace(" active", "");
    this.className += " active";
  });
}