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