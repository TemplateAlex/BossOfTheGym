//Create logic and animation for cards
var regCard = document.querySelector(".reg-card");
var logCard = document.querySelector(".log-card");

document.querySelector(".checkbox").addEventListener("change", function (event) {
    if (this.checked) {
        regCard.style.transform = "translateX(-50%) rotateY(360deg)";
        logCard.style.transform = "translateX(-50%) rotateY(180deg)";
    }
    else {
        regCard.style.transform = "translateX(-50%) rotateY(180deg)";
        logCard.style.transform = "translateX(-50%) rotateY(0deg)";
    }
});

//Create messagebox about warnings for user
document.querySelector(".email-form__reg").addEventListener("input", function (event) {
    var email = this.value;
    var msgBox = document.querySelector(".msg-error__email");

    if (email.indexOf("@") == -1) msgBox.innerHTML = "Error with domain! Write your email right.";
    else msgBox.innerHTML = "";
});

document.querySelector(".rpsswd-form__reg").addEventListener("input", function (event) {
    var rpsswd = this.value;
    var psswd = document.querySelector(".psswd-form__reg").value;
    var msgBox = document.querySelector(".msg-error__psswdReg");

    if (psswd == rpsswd) msgBox.innerHTML = "";
    else msgBox.innerHTML = "Passwords don't match!";
});
