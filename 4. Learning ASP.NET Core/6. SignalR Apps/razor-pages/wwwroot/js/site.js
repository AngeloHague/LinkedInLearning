// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder()
	.withUrl("/messageHub")
	.build();

connection.on("ReceiveNewMessage", (message) => {
	let paragraph = document.createElement("p");
	paragraph.textContent = message;
	document.getElementById("newMessages").appendChild(paragraph);
});

connection.start();

document.getElementById("send").addEventListener("click", (e) => {
    e.preventDefault();
    let message = document.getElementById("messageInput").value;
    connection.invoke("PostMessage", message).catch((err) => console.error('Error sending message: ', err.toString()));
})
