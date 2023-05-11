let textPost = document.getElementById("textPost");
let btn_Addpost = document.getElementById("btnAddpost");
let QuerisData = document.getElementById("QuerisData");

let arrHaveallQueries =[];
let cartona = ``;
QuerisData.innerHTML = `<div class="col-lg-12 d-flex align-items-center containerEnquery shadowBox position-relative">
<div class="DataOfPersoneOfGraduated position-absolute start-0 d-flex">
  <img src="../Image/Eich.jpg" alt="" class="rounded-circle PicPersonHavePost">
  <h5 class="text-black mx-2">Yassin Alaa</h5>
</div>
<div class="container-fluid  ">
  <div class="row w-100">
    <div class="col-lg-12">
    <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Autem, quo neque pariatur rem
    aspernatur dolore accusamus
    non itaque obcaecati laboriosam quae id soluta laborum doloremque totam, amet quibusdam veritatis?
    Pariatur!</p>
    
    </div>
  </div>
</div>
</div>



<div class="col-lg-12 d-flex align-items-center containerEnquery shadowBox position-relative">
<div class="DataOfPersoneOfGraduated position-absolute start-0 d-flex">
  <img src="../Image/HowItwork.png" alt="" class="rounded-circle PicPersonHavePost">
  <h5 class="text-black mx-2">Yassin Alaa Yassin</h5>
</div>
<div class="container-fluid  ">
  <div class="row w-100">
    <div class="col-lg-12">
    <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Autem, quo neque pariatur rem
    aspernatur dolore accusamus
    non itaque obcaecati laboriosam quae id soluta laborum doloremque totam, amet quibusdam veritatis?
    Pariatur!</p>
    
    </div>
  </div>
</div>
</div>
`;


function addQueryis()
 {
  let query = textPost.value;
  arrHaveallQueries.push(query);
  showAllPost();
 
}

function showAllPost()
{
  cartona=``;

  for (var i = (arrHaveallQueries.length)-1; i >=0; i--) 
  {
    cartona += `<div class="col-lg-12 d-flex align-items-center containerEnquery shadowBox position-relative containerEnqueryAdmin" >
    <div class="DataOfPersoneOfGraduated position-absolute start-0 d-flex">
    <img src="http://i.pravatar.cc/500?img=7"  alt="" class="rounded-circle PicPersonHavePost">
      <h5 class="text-black mx-2">Ahmed</h5>
    </div>
    <div class="container-fluid  ">
      <div class="row w-100">
        <div class="col-lg-12">
    <p>${arrHaveallQueries[i]}</p>
        
        </div>
      </div>
    </div>
    </div>`;
  }

  cartona +=`
<div class="col-lg-12 d-flex align-items-center containerEnquery shadowBox position-relative">
 <div class="DataOfPersoneOfGraduated position-absolute start-0 d-flex">
   <img src="../Image/Eich.jpg" alt="" class="rounded-circle PicPersonHavePost">
   <h5 class="text-black mx-2">Yassin Alaa</h5>
 </div>
 <div class="container-fluid  ">
   <div class="row w-100">
     <div class="col-lg-12">
     <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Autem, quo neque pariatur rem
     aspernatur dolore accusamus
     non itaque obcaecati laboriosam quae id soluta laborum doloremque totam, amet quibusdam veritatis?
     Pariatur!</p>
     
     </div>
   </div>
 </div>
</div>



<div class="col-lg-12 d-flex align-items-center containerEnquery shadowBox position-relative">
 <div class="DataOfPersoneOfGraduated position-absolute start-0 d-flex">
   <img src="../Image/HowItwork.png" alt="" class="rounded-circle PicPersonHavePost">
   <h5 class="text-black mx-2">Yassin Alaa Yassin</h5>
 </div>
 <div class="container-fluid  ">
   <div class="row w-100">
     <div class="col-lg-12">
     <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Autem, quo neque pariatur rem
     aspernatur dolore accusamus
     non itaque obcaecati laboriosam quae id soluta laborum doloremque totam, amet quibusdam veritatis?
     Pariatur!</p>
     
     </div>
   </div>
 </div>
</div>
`;



  QuerisData.innerHTML = cartona;

  textPost.value = ``;
}




btn_Addpost.addEventListener('click', addQueryis)



