function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function(e) {
            $('#imagePreview').css('background-image', 'url('+e.target.result +')');
            $('#imagePreview').hide();
            $('#imagePreview').fadeIn(650);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#imageUpload").change(function() {
    readURL(this);
});



let accepttBtn =document.querySelector(".accepttBtn");
let Rejectedbtn =document.querySelector(".Rejectedbtn");
let ShadowBox=document.getElementById("form");

accepttBtn.addEventListener("click",
function(){ShadowBox.click() })

Rejectedbtn.addEventListener("click",
function(){ShadowBox.click() })
