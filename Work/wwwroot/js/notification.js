"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

//Disable send button until connection is established
$('.SendRequest').disabled = true;


connection.on("ReceiveRequest", function (sender) {

    var msg = document.createElement("div");
    var NotificationCount = document.querySelector(".alertNotification p").textContent;
    var Count = parseInt(NotificationCount);
    console.log(Count);

    Count = Count + 1;
    document.querySelector(".alertNotification p").innerHTML = Count;
    console.log(NotificationCount);
    console.log(Count);

    document.getElementById("form").appendChild(msg);

    msg.innerHTML = `
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content py-md-5 px-md-4 p-sm-3 p-4">
              <h3>Request</h3> <i class="fa fa-bell"></i>
              <p class="r3 px-md-5 px-sm-1"><span class="text-danger">${sender} </span> wants to chat with  you</p>
              <div class="text-center mb-3">
                <button class="btn btn-success w-50 rounded-pill b1 accepttBtn"><a href="/Home/Profile" class="text-decoration-none text-white">Accept</a></button>
              </div>
              <div class="text-center">
                <button class="btn btn-danger w-50 rounded-pill Rejectedbtn"><a href="/Home/Profile" class="text-decoration-none text-white">Reject</a></button>
              </div> 
            </div>
        </div>
    `;    

});


connection.start().then(function () {
    document.getElementsByClassName("SendRequest").disabled = false;
    console.log("connection.start");

}).catch(function (err) {
    return console.error(err.toString());
    console.log("connection.Failed");

});


$('.SendRequest').on('click', function (event) {
    var button = $(event.target)

    var sender = button.attr('data-sender_email');
    var receiver = button.attr('data-receiver_email');
    var PId = button.attr('data-PId') ?? null;
    //var title = button.attr('data-title');

    console.log("Before Invoke");

    connection.invoke("SendNotification", sender, receiver, PId).catch(function (err) {
        return console.error(err.toString());
    });

    console.log("After Invoke");

    event.preventDefault();
})

//document.querySelectorAll("#SendRequest").addEventListener("click", function (event) {
//    var button = event.target;

//    var sender = button.getAttribute('data-sender_email')
//    var receiver = button.getAttribute('data-receiver_email')
//    var message = button.getAttribute('data-message')
//    console.log("Before Invoke");
//    console.log(sender);
//    console.log(receiver);
//    console.log(message);

//    connection.invoke("SendNotification", sender, receiver, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    console.log("After Invoke");

//    event.preventDefault();
//});