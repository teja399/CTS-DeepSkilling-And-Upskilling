$(function () {

    $("#addBtn").click(function () {

        const value = $("#item").val();

        $("ul").append("<li>" + value + "</li>");

        $("#item").val("");

    });

    $("#removeBtn").click(function () {

        $("ul").empty();

    });

});
