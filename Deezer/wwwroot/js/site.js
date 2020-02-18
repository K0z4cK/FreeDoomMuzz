// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function validateForm() {
    let userName = document.forms["myForm"]["UserName"].value;
    let firstName = document.forms["myForm"]["fEmail"].value;
    let lastName = document.forms["myForm"]["fEmail"].value;
    let password = document.forms["myForm"]["fEmail"].value;
    let passwordConfirm = document.forms["myForm"]["fEmail"].value;
    if (userName.Length >= 5) {
        document.["UserName"].value = "User First Name length must be more than 4 symbols";
        return false;
    }
}