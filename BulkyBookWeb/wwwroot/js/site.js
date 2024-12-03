// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
    const mainVideo = document.getElementById("main-video");
    const loopingVideo = document.getElementById("looping-video");
    const choicesOverlay = document.querySelector(".choices-overlay");

    mainVideo.onended = () => {
        mainVideo.style.display = "none";

        loopingVideo.style.display = "block";
        loopingVideo.play();

        choicesOverlay.style.display = "flex";
    };
});

function choosePath(choice) {
    console.log(choice)
    $.ajax({
        url: '/Home/Choice',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(choice),
        success: function (response) {
            document.open();
            document.write(response);
            document.close();
        },
        error: function (xhr, status, error) {
            console.error("Error:", status, error);
        }
    });
}
