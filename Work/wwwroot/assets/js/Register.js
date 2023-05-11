let Username=document.getElementById("EmailNameInput");
let EmailAddress=document.getElementById("emailAdress");
let  Password=document.getElementById("PasswordElement");
let rePassword =document.getElementById("Repassword");
let errorsSubmite=document.getElementById("errorsSubmite");
let reguxUserName=/^[A-Za-z ]{6,}$/;
// regualr experssion character onely  and min 6 
let reguxOfEmail= /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/;
let BtnCreateAccount=document.getElementById("BtnAccount");


// console.log(Username)
// console.log(EmailAddress)
// console.log(Password)
// console.log(rePassword)

function AddInvalid(x)
{
   
    if( x.classList.contains("is-invalid")==false ||x.classList.contains("is-valid")==false)
    {
        x.classList.add('is-invalid')
    }
}

function checkValidOrNot(regu, Element)
{
    if(regu.test(Element.value)==true)
    {
        Element.classList.replace("is-invalid","is-valid")
    }
    else
    {
        Element.classList.replace("is-valid","is-invalid")

    }
}


Username.addEventListener("input",function(e)
{
    AddInvalid(e.target);
    checkValidOrNot(reguxUserName, e.target);
})


EmailAddress.addEventListener("input",function(e)
{
    AddInvalid(e.target);
    checkValidOrNot(reguxOfEmail, e.target)
})






Password.addEventListener("input",function(e)
{
    AddInvalid(e.target);
    console.log(Password.value.length);
    if(Password.value.length>6==true)
    {
        Password.classList.replace("is-invalid","is-valid");
    }
    else
    {
        Password.classList.replace("is-valid","is-invalid");
    }

})



rePassword.addEventListener("input",function(e)
{
    AddInvalid(e.target);
    console.log(e.target.value)
    if(e.target.value.length>6==true && e.target.value==Password.value)
    {
        e.target.classList.replace("is-invalid","is-valid");
    }
    else
    {
        e.target.classList.replace("is-valid","is-invalid");
    }

})


BtnCreateAccount.addEventListener("click",function()
{
    let ReferToLoginFile=document.getElementById("ReferToLoginFile");

        if(Username.value==''||EmailAddress.value==''||Password.value==''||rePassword.value=='' ||Username.classList.contains("is-invalid")  ||
        EmailAddress.classList.contains("is-invalid") ||Password.classList.contains("is-invalid") ||rePassword.classList.contains("is-invalid") )
        {
                errorsSubmite.classList.replace('d-none','d-block');
        }
        else
        {
            ReferToLoginFile.setAttribute('href',"Login.html")
        }


}
 )

