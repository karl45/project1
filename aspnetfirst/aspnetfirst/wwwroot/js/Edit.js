
document.getElementById("Save").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendEdit", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    //event.preventDefault();
});