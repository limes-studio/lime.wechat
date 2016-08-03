$(document).ready(function () {
    $("a.ajax_link").click(function (e) {
        e.preventDefault(); // prevent default link button redirect behaviour
        var url = $(this).attr("href");
        if (url != '#' && url != '') {
            $('.content-wrapper').load(url);
            $("li.active").eq(0).removeClass("active");
            $(this).parent().addClass("active");
        }

    });
});

$(document).ajaxStart(function () { Pace.restart(); });