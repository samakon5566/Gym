"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established

connection.on("ReceiveMessage", function (content) {
    var p  = document.createElement("p");
    p.textContent = content;
    document.getElementById("messagesList").appendChild(p);
    var message = document.getElementById("messageInput").value;
});

connection.on("RecAddGroupMsg", function (message) {
    var p  = document.createElement("p");
    p.style.color = "#ADADAD";
    p.textContent = message;
    document.getElementById("messagesList").appendChild(p);
});

connection.on("RecLeaveGroupMsg", function (message) {
    var p = document.createElement("p");
    p.style.color = "#ADADAD";
    p.textContent = message;
    document.getElementById("messagesList").appendChild(p);
});

// 群組訊息接收事件
connection.on("ReceiveGroupMessage", function (username, message,time, userId, path,typeId) {
    var user = document.getElementById('userId').value;
    var myMsgList = document.getElementById('messagesList');
    if (user == userId) {
        if (typeId == "3") {
            myMsgList.innerHTML += '<div class="myMsg"><div style="text-align:right">\
                 <label class="Msg">' + message + '</label>\
                <label style="color:white">教練 </label><label class="people">'+ username + '</label >\
                <img class="photo" src="../img/LoginFigure/' + path + '"/></div>\
                </div > ';
        }
        else {
            myMsgList.innerHTML += '<div class="myMsg"><div style="text-align:right">\
                 <label class="Msg">' + message + '</label>\
                <label style="color:white">學員 </label><label class="people">'+ username + '</label >\
                <img class="photo" src="../img/LoginFigure/' + path + '"/></div>\
                </div > ';
        }
    }
    else {
        if (typeId == "3") {
            myMsgList.innerHTML += '<div class="otherMsg"><img class="photo" src="../img/LoginFigure/' + path + '"/>\
      <label style="color:white">教練 </label><label class="people">'+ username + '</label><label class="Msg">' + message + '</label></div>';
        }
        else {
            myMsgList.innerHTML += '<div class="otherMsg"><img class="photo" src="../img/LoginFigure/' + path + '"/>\
      <label style="color:white">學員 </label><label class="people">'+ username + '</label><label class="Msg">' + message + '</label></div>';
        }
    }
});

connection.start().then(function () {
    document.getElementById("submitGroupBtn").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("AddGroupBtn").addEventListener("click", function (event) {
    var user = document.getElementById("name").innerHTML;
    var group = document.getElementById("group").value;
    connection.invoke("AddGroup", group, user).catch(function (err) {
        return console.error(err.toString());
    });
});

document.getElementById("LeaveGroupBtn").addEventListener("click", function (event) {
    var user = document.getElementById("name").innerHTML;
    var group = document.getElementById("group").value;
    connection.invoke("LeaveGroup", group, user).catch(function (err) {
        return console.error(err.toString());
    });
});


// 群組訊息Button事件
document.getElementById("submitGroupBtn").addEventListener("click", function (e) {
    var user = document.getElementById("name").innerHTML;
    var group = document.getElementById("group").value;
    var message = document.getElementById("messageInput").value;
   /* var textareaArray = document.getElementsById("messageInput");*/
  /*  console.log(message);*/
    document.getElementById("messageInput").value = "";
    var userId = document.getElementById("userId").value;
    var TypeId = document.getElementById("userTypeId").value;
    var path = document.getElementById("userFigure").value;
    document.getElementById("messageInput").value = "";
    connection.invoke("SendMessageToGroup", group, user, message, userId, path,TypeId).catch(function (err) {
        return console.error(err.toString());
    });    
});
