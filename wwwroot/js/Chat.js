//CONNECT
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
document.getElementById("sendBtn").disabled = true;

//GET MESSAGE
connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + ": " + msg;
    var li1 = document.createElement("li");
    var icon = document.createElement("i");
    //icon.class.add("fa-li fa fa-check-square");

    li1.classList.add("list-group-item");
    li1.style.fontWeight = "bold";
    li1.textContent = user;
    li1.appendChild(icon);

    var li2 = document.createElement("li");
    li2.classList.add("list-group-item");
    li2.style.marginBottom = "20px";
    li2.style.background = "#EBEBEB";
    li2.textContent = msg;
    document.getElementById("messagesList").appendChild(li1);
    document.getElementById("messagesList").appendChild(li2);
});

connection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

//SEND MESSAGE
document.getElementById("sendBtn").addEventListener("click", function (event) {
    var user = document.getElementById("userName").value;
    var message = document.getElementById("userMessage").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});