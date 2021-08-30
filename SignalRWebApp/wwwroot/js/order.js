﻿"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/orderHub").build();

//Disable send button until connection is established
document.getElementById("sendOrder").disabled = true;

connection.on("ReceiveOrderStatus", function (message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${message}`;
});

connection.start().then(function () {
    document.getElementById("sendOrder").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendOrder").addEventListener("click", function (event) {
    connection.invoke("SendMessage").catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});