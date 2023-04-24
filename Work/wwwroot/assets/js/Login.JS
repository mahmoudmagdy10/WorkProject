let EmailInpute=document.getElementById("EmailInputes");
let PasswordLogin=document.getElementById("PasswordLogin");
let btnsubmite=document.getElementById("submiteFormOFLogin");

let reguxOfEmail= /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/;


EmailInpute.addEventListener('input',function(e)
{
    let DataEle=e.target;
    AddClassInfirstType(DataEle)
    if(reguxOfEmail.test(EmailInpute.value)==1)
    {
        CheckValidOrNotandMakeChange(DataEle)

    }
} )

PasswordLogin.addEventListener("input",function(e)
{
    let DataEle=e.target;
    AddClassInfirstType(DataEle)

    if(PasswordLogin.value.length>6)
    {
        CheckValidOrNotandMakeChange(DataEle)
    }

})



function AddClassInfirstType(x)
{
    if(x.classList.contains("is-invalid")==false ||x.classList.contains("is-valid")==false)
    {
        x.classList.add("is-invalid")
    }
 
}





function CheckValidOrNotandMakeChange(x)
{
    if(x.classList.contains("is-invalid")==true)
    {
        x.classList.replace("is-invalid","is-valid")
    }
    else
    {
        x.classList.replace("is-valid","is-invalid")

    }
}

btnsubmite.addEventListener("click",function ()
{
    let errorsShow=document.getElementById("errorsSubmite");
    let targetPassword=PasswordLogin;
    let targetEmail=EmailInpute;
    let LoginBtn=document.getElementById("LoginBtn");

    
    console.log(errorsShow)
if(targetEmail.value=='' ||targetPassword.value==''||targetEmail.classList.contains("is-invalid")==true|| targetEmail.classList.contains("is-invalid")==true )
{
    errorsShow.classList.replace("d-none","d-block");
}
else 
{   
    
    LoginBtn.setAttribute("href","GraduitedHomePage.html")
    LoginBtn.click();

}
console.log(LoginBtn)







} )