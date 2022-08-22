//Create effect parallax
document.querySelector(".coachers__wrapper").addEventListener("mousemove", function (event) {
    document.querySelectorAll(".background").forEach(elem => {
        elem.style.transform = "translate(" + event.clientX / 500 + "px," + event.clientY / 500 + "px)";
    });
});