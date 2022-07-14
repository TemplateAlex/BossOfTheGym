document.addEventListener("mousemove", function (event) {
    document.querySelectorAll(".background").forEach(elem => {
        elem.style.transform = "translate(" + event.clientX / 150 + "px," + event.clientY / 150 + "px)";
    });
});