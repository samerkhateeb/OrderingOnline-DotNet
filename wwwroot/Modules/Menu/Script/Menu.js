$(document).ready(function () {

    // Load Values for the site
    $('#MenuTop a').click(function (e) {
     // alert('i am in Menu');
        //Cancel the link behavior
        e.preventDefault();
        // Check if order Type registered
        if ($.cookie("OrderType") != "" && $.cookie("OrderType") != null) {
            // move to the current location
        //  alert($.cookie("OrderType"));
            window.location.href = $(this).attr('href');
        }
        else {
        //  alert('i am in popup');
            GoToOpenPopup($(this));
        }

    });

});


//function ClickMenu() {
//    alert('i am in');
//    if ($.cookie("OrderType") != null) {
//        // move to the current location
//        window.location.href = $(this).attr('href');
//    }
//    else
//        ShowPopup($(this));
//}