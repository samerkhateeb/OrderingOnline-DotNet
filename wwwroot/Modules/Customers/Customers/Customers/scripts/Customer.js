
$(function () {

    $(LoginPasswordTextBox).keypress(function (event) {
        if (event.keyCode == 13) {
            $(LoginButton).click();
        }
    });
        



});