// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("wheel", function (e){
    if (e.ctrlKey) e.preventDefault();
}, {passive: false});

document.addEventListener("keydown", function (e) {
    if(e.ctrlKey && ["+", "-", "="].includes(e.key))
        e.preventDefault();
});