"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

// ----------------------------------------------------------------------
//document.getElementById("SendRequest").disabled = true;
// ----------------------------------------------------------------------

connection.on("ReceiveMessage", function (sender, message, SendPhoto) {
    var MsgBody = document.createElement("div");
    document.getElementById("chat-area-main").appendChild(MsgBody);

    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you
    // should be aware of possible script injection concerns.

    MsgBody.innerHTML = `
        <div class="chat-msg owner" style=" flex-flow:row-reverse">
            <div class="chat-msg-profile">
                <img class="chat-msg-img SendPhoto" src="${SendPhoto}">
                <div class="chat-msg-date">Just Now</div>
            </div>
            <div class="chat-msg-content">
                <div class="chat-msg-text" style="background-color:#333456);
                    color:ffffff">
                    ${message}
                </div>
            </div>
        </div>     
    `;

   
});

// ----------------------------------------------------------------------
//connection.on("ReceiveRequest", function (user) {
//    var li = document.createElement("li");
//    document.getElementById("NotificationList").appendChild(li);
//    var userName = document.getElementById("userId").value;

//    // We can assign user-supplied strings to an element's textContent because it
//    // is not interpreted as markup. If you're assigning in any other way, you 
//    // should be aware of possible script injection concerns.
//    li.textContent = `${user} Send A Request To Chat !`;
//});
// ----------------------------------------------------------------------

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;

// ----------------------------------------------------------------------
//    document.getElementById("SendRequest").disabled = false;
// ----------------------------------------------------------------------

    console.log("connection.start");

}).catch(function (err) {
    return console.error(err.toString());
    console.log("connection.Failed");

});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userId").value;
    var receiver = document.getElementById("receiverInput").value;
    var message = document.getElementById("messageInput").value;
    var SendPhoto = $(".SendPhoto").attr("src") ?? "https://d30y9cdsu7xlg0.cloudfront.net/png/138926-200.png";

    console.log("sendButton is clicked");

    connection.invoke("SendToGroup", "ChatGrouping", message, user, receiver, SendPhoto).catch(function (err) {
        return console.error(err.toString());
    });
    console.log("sendButton after is clicked");
    document.getElementById("messageInput").value = "";
    event.preventDefault();
});



document.getElementById("conversation-area").addEventListener("click", function (event) {

    ClickJoinGroup();
    document.getElementById("chat-area-main").style.display = "block";
});


function ClickJoinGroup()
{
    var user = document.getElementById("userId").value;
    var receiver = document.getElementById("receiverInput").value;

    console.log("JoinGroup Button is clicked");

    connection.invoke("JoinGroup", `ChatGrouping`).catch(function (err) {
        return console.error(err.toString());
    });
}


//document.getElementById("JoinGroup").addEventListener("click", function (event) {

//    var user = document.getElementById("userId").value;
//    var receiver = document.getElementById("receiverInput").value;

//    console.log("JoinGroup Button is clicked");

//    connection.invoke("JoinGroup", `ChatGrouping`).catch(function (err) {
//        return console.error(err.toString());
//    });
//    document.getElementById("chat-area-main").style.display = "block";
//});