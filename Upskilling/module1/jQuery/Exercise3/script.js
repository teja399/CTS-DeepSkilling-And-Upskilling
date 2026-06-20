$(function () {

    $("#hideBtn").click(() => $(".box").hide());

    $("#showBtn").click(() => $(".box").show());

    $("#fadeOutBtn").click(() => $(".box").fadeOut());

    $("#fadeInBtn").click(() => $(".box").fadeIn());

    $("#toggleBtn").click(() => {

        $(".box")
            .slideUp()
            .delay(1000)
            .slideDown();

    });

});
