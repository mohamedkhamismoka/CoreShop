
$(document).ready(function () {
    $(".app-sidebar__toggle").click(function () {
        if ($(".app-sidebar").css("display") == "none") {
            $(".app-sidebar").css("display", "inline-block")
        } else {
            $(".app-sidebar").css("display", "none")
        }
    })
})