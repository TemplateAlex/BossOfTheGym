﻿//Create flip card
document.querySelectorAll(".coacher-card__wrapper").forEach(elem => {
    elem.addEventListener("mousemove", function (event) {
        this.querySelector(".coacher-card__top").style.transform = "rotateY(90deg)";
        this.querySelector(".coacher-card__back").style.transform = "rotateY(0deg)";
    });
    elem.addEventListener("mouseout", function (event) {
        this.querySelector(".coacher-card__top").style.transform = "rotateY(0deg)";
        this.querySelector(".coacher-card__back").style.transform = "rotateY(-90deg)";
    });
});