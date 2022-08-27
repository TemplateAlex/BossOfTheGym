//Create flip card
document.querySelectorAll(".coacher-card__wrapper").forEach(elem => {
    elem.addEventListener("mousemove", function (event) {
        this.querySelector(".coacher-card__top").style.transform = "rotateX(90deg) rotateY(90deg)";
        this.querySelector(".coacher-card__back").style.transform = "rotateX(0deg) rotateY(0deg)";
    });
    elem.addEventListener("mouseout", function (event) {
        this.querySelector(".coacher-card__top").style.transform = "rotateX(0deg) rotateY(0deg)";
        this.querySelector(".coacher-card__back").style.transform = "rotateX(-90deg) rotateY(-90deg)";
    });
});

//Create checker for information
var emailInput = document.querySelector(".email-form__input")
var msgBox = document.querySelector(".msg-error__email");

$(document).ready(function () {
    setInterval(function () {
        var textInput = emailInput.value;

        if (textInput.indexOf("@") == -1 && textInput.length > 0) msgBox.innerHTML = "Invalid email";
        else msgBox.innerHTML = "";
    }, 100);
});
