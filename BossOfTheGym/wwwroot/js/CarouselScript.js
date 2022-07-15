//Create slider script
$(document).ready(function () {
    var index = 0;

    setInterval(function () {
        var carouselItems = document.querySelectorAll(".slider-element");
        carouselItems[index].classList.remove("active-element");

        if (index + 1 >= carouselItems.length) index = 0
        else index += 1;

        carouselItems[index].classList.add("active-element");

    }, 2500);
});


//Create leaning card
var card = document.querySelector(".slider-container");
const halfCard = document.querySelector(".slider-container").offsetHeight / 2;

card.addEventListener("mousemove", function (event) {
    this.style.transform = "rotateX(" + (halfCard - event.offsetY) / 5 + "deg) rotateY(" + (event.offsetX - halfCard) / 5 + "deg)";
});

card.addEventListener("mouseout", function (event) {
    this.style.transform = "rotateX(0deg) rotateY(0deg)";
});