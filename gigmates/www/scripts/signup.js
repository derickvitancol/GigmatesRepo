$(document).ready(function () {
    $("#proceedButton").click(function ()
    {

        
        var NewPersonInfo = {
            firstname: document.getElementById("FirstnameBox").value,
            lastname: document.getElementById("LastnameBox").value,
            username: document.getElementById("UsernameBox").value,
            password: document.getElementById("PasswordBox").value,
            address: document.getElementById("AddressBox").value,
            gender: document.getElementById("GenderBox").value,
            age: document.getElementById("AgeBox").value,
            usertype: document.getElementById("UserTypebox").value,
        }

    });
});