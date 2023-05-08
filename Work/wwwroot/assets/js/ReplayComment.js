let SectionComment= document.getElementById("comment-Sectiom")
let InputeComment=document.getElementById("InputeComment");
let send =document.getElementById("button-addonReplay");
let cartona=``
var storevalue=[];
const date =new Date()


function addValue()
{

    if(InputeComment.value !='')
    {
        storevalue.push(InputeComment.value)
    }
    InputeComment.value='';
    ShowComment()
}

function ShowComment()
{

cartona=``;
for(let i=storevalue.length-1 ;i>=0;i--)
{

cartona +=`

<div class="media media-review">
<div class="media-user"><img src="../Image/profMurad.jpeg" alt=""></div>
<div class="media-body">
  <div class="M-flex">
    <h2 class="title"><span> Prof:Murad </span>${date.getDay()}-${date.getMonth()}-${date.getFullYear()}</h2>
  </div>
  <div class="description ps-2">
    <p> ${storevalue[i]}</p>
  </div>
</div>
</div>
`


}
SectionComment.innerHTML=cartona;







}



send.addEventListener("click",function()
{
    addValue()





} )