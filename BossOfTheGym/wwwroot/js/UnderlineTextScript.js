//Create underlined with div
document.querySelectorAll(".underline-text__wrapper").forEach(elem => {

    elem.addEventListener("mouseover", function (event) {
        elem.querySelector(".unline").style.width = 100 + "%"; 
    });

    elem.addEventListener("mouseout", function (event) {
        elem.querySelector(".unline").style.width = 0 + "%";
    });
});