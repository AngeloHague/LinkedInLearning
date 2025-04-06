// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var connection = new signalR.HubConnectionBuilder()
	.withUrl("/salesHub")
	.build();

connection.on("ReceiveNewHighSale", (message) => {
    console.log(message)
	let paragraph = document.createElement("p");
	paragraph.textContent = message.employee + " made a sale of $" + message.amount;
	document.getElementById("highSales").appendChild(paragraph);
});

connection.start();

document.getElementById("send").addEventListener("click", (e) => {
    e.preventDefault();
    let amount = document.getElementById("amount").value;
    let employee = document.getElementById("employee").value;
    connection.invoke("PostNewSale", 
       amount, employee
    ).catch((err) => console.error('Error sending message: ', err.toString()));
})
