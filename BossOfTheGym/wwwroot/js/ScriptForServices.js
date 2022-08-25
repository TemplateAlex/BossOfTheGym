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

//Create checker for information;
document.querySelector(".tel-form__input").addEventListener("input", function (event) {
    var telNum = this.value;
    var msgBox = document.querySelector(".msg-error__tel");
    var checker = false;

    for (var i = 0; i < telNum.length; i++) {
        var codeASCII = telNum[i].charCodeAt(0);

        if (codeASCII < 48 || codeASCII > 57) {
            checker = true;
        }

        if (checker) {
            msgBox.innerHTML = "Invalid telephone number";
        }
        else {
            msgBox.innerHTML = "";
        }
    }
});