 
var connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .build();


$(document).ready(function () {
    connection.start();

});

function SendMessage_sign(message) {
      

    connection.invoke('SendNewMessage', message);
}


connection.on('getNewMessage', getNewMessage_sign);

function getNewMessage_sign(message) {

    addMessageToMessageArea(message);
}


