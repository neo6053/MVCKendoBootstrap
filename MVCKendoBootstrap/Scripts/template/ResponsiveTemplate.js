
$(document).ready(function () {
    $("#drawer").kendoMobileDrawer({
        container: "#content-container",
        swipeToOpen: false
    });

    if (matchMedia) {
        var mq = window.matchMedia("(min-width: 1281px)");
        WidthChange(mq);
    }
    $("#drawer-trigger").click(function () {
        var drawer = $("#drawer").data("kendoMobileDrawer");
        if (drawer.visible)
            drawer.hide();
        else
            drawer.show();
        return false;
    });
});


// reponsive scripts need to be execute
if (matchMedia) {
    var mq = window.matchMedia("(min-width: 1281px)");
    mq.addListener(WidthChange);
    WidthChange(mq);
}

function WidthChange(mq) {
    var drawer = $("#drawer").data("kendoMobileDrawer");
    if (mq.matches) {
        if (drawer) {
            drawer.hide();
            drawer.destroy();
        }
    }
    else {
        $("#drawer").kendoMobileDrawer({
            container: "#content-container",
            swipeToOpen: true
        });
    }
}