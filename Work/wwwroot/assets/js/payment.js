let boxVisa =document.querySelector(".visaCard");
let InputesboxVisa =document.querySelectorAll(".visaCard input");


let VfCashBox =document.querySelector(".VodafonCash");
let InputesVfCashBox =document.querySelector(".VodafonCash input");

for(var x =0; x<InputesboxVisa.length;x++)
{

    InputesboxVisa[x].addEventListener("click",function()
    {      
    if(VfCashBox.classList.contains("Active")==true)
    {
        VfCashBox.classList.replace("Active","notActive")
    }
    boxVisa.classList.add("Active")


    
    } )
}


InputesVfCashBox.addEventListener("click",function()
{

    if(boxVisa.classList.contains("Active")==true)
    {
        boxVisa.classList.replace("Active","notActive")
    }
    VfCashBox.classList.add("Active")

} )

// InputesboxVisa[0].addEventListener("click",function(){console.log("asdasd")});





console.log(boxVisa)

console.log(InputesboxVisa)
console.log(VfCashBox)
console.log(InputesVfCashBox)


// 
// border-radius: 32px;
// background: rebeccapurple;
// transform: scale(1.0);

// 