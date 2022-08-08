$(document).ready(() => {
    $("input[type=text]").on("input", elem => {
        elem.currentTarget.nextElementSibling?.focus();
    }).focusin(elem => $(elem.currentTarget).val(""));
    $("input[type=text]:first").focus();

    $("#play-again").on("click", elem => {
        if (!elem.currentTarget.disabled) {
            window.location = "/home/index";
        }
    });
});
