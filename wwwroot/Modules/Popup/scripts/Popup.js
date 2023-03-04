/// <reference path="jquery-1.7.2.min.js" />

var LocationsDropDownList,
GridsDropDownList, GridCodeValue, LocationCodeValue, href = ' ';
$(document).ready(function () {


    //  $('#' + GridsDropDownList).append(new Option('---- Select Area ----', 0));

    //if close button is clicked
    $('#CancelOrderType').click(function (e) {
        // check if the fadein completed or not
        if ($(':animated').length) {
            return false;
        }
        else {
            //Cancel the link behavior
            e.preventDefault();
            // check if the open popup source is not load, its not available if the source is the page load
            if (href != " ")
                resetLayout();
        }
    });

    //if mask is clicked
    $('#mask').click(function () {
        $(this).hide();
        $('.window').hide();
    });

    $(window).resize(function () {

        var box = $('#boxes .window');

        //Get the screen height and width
        var maskHeight = $(document).height();
        var maskWidth = $(window).width();

        //Set height and width to mask to fill up the whole screen
        $('#mask').css({ 'width': maskWidth, 'height': maskHeight });

        //Get the window height and width
        var winH = $(window).height();
        var winW = $(window).width();

        //Set the popup window to center
        box.css('top', winH / 2 - box.height() / 2);
        box.css('left', winW / 2 - box.width() / 2);

    });



    // OrderType - RadioButton Event
    $('input[name=OrderTypeRadio]').click(function (e) {
        var value = $(this).attr('value');
        if (value == "PU") {
            $("#GridDiv").show();
        }
        else
            $("#GridDiv").hide();


    });


    //    // on DropDownList Change
    //    $('#' + GridsDropDownList).change(function (e) {

    //        if ($(this).val() != "0") {


    //        // refill the data again
    //            $('#' + BlocksFullDropDownList).find('option').clone().appendTo('#' + BlocksDropDownList);

    //        // filter the options
    //            $('#' + BlocksDropDownList).find('option').each(function () {
    //                if ($(this).val().toLowerCase() != $('#' + GridsDropDownList).val().toLowerCase()) {
    //                    $(this).remove();
    //                }
    //            });
    //            $('#BlockDiv').show();
    //            $('#' + BlocksDropDownList).show();
    //        }
    //        else {
    //            $('#BlockDiv').hide();
    //            $('#' + BlocksDropDownList).hide();
    //        }

    //    });



    // on Locations DropDownList Change
    $('#' + LocationsDropDownList).change(function (e) {

        if ($(this).val() != "0") {

            LocationCodeValue = $(this).val();

            // filter the options
            $('#' + GridsDropDownList).find('option').each(function () {
                if ($(this).text().toLowerCase() == $('#' + LocationsDropDownList).val().toLowerCase()) {
                    GridCodeValue = $(this).val().toLowerCase().replace(" ", "_");
                    return false;
                    //    break;
                }
            });

        }
        else {
            LocationCodeValue = "0";
            GridCodeValue = "";
        }


    });



    $('#SelectOrderType').click(function (e) {

            e.preventDefault();
            if ($("input[name='OrderTypeRadio']:checked").val() == "HD" || ($("input[name='OrderTypeRadio']:checked").val() == "PU" && $('#' + LocationsDropDownList).val() != "0")) {
                $.cookie("OrderType", $("input[name='OrderTypeRadio']:checked").val(), { expires: 7, path: '/' });
                $.cookie("OrderLocation", $('#' + LocationsDropDownList).val(), { expires: 7, path: '/' });
                $.cookie("OrderGrid", GridCodeValue, { expires: 7, path: '/' });

                // $.cookie("OrderBlock", $('#' + BlocksDropDownList + ' option:selected').text(), { expires: 7, path: '/' });

                resetLayout();

                // move to the current location
                if (href != ' ')
                    window.location.href = href;
                //window.location.href = $(this).attr('href');

            }
        
    });

    //    //select all the a tag with name equal to modal
    //    $('a[name=MenuHyperLink]').click(function (e) {
    //        //Cancel the link behavior
    //        e.preventDefault();
    //        alert('i am in');
    //        if ($.cookie("OrderType") !=null ) {
    //            // move to the current location
    //            window.location.href = $(this).attr('href');
    //        }
    //        else
    //        ShowPopup($(this));

    //    });

    //select all the a tag with name equal to modal
    //    $('a[name=modal]').click(function (e) {
    //        //Cancel the link behavior
    //        e.preventDefault();

    //        ShowPopup($(this));

    //    });



});


function GoToOpenPopup(sender) {

    if (sender != null && sender != " ") {
        href = $(sender).attr('href');
        $('#SelectOrderType').attr('href', href);
    }

    ShowPopup();
}

function ShowPopup() {

    //Get the A tag $(sender).attr('href')
    var id = '#dialog';
    //Get the screen height and width
    var maskHeight = $(document).height();
    var maskWidth = $(window).width();

    //Set heigth and width to mask to fill up the whole screen
    $('#mask').css({ 'width': maskWidth, 'height': maskHeight });

    //transition effect		
    $('#mask').fadeIn(200);
    $('#mask').fadeTo("slow", 0.8);

    //Get the window height and width
    var winH = $(window).height();
    var winW = $(window).width();

    //Set the popup window to center
    $(id).css('top', winH / 2 - $(id).height() / 2);
    $(id).css('left', winW / 2 - $(id).width() / 2);

    //Fade In Popup window
    $(id).fadeIn(100);
}





function resetLayout() {

   // alert($("input[name='OrderTypeRadio']:checked").index());


    // close window
    $('#mask').hide();
    $('.window').hide();

    $("#" + LocationsDropDownList).val("0");
    $('#GridDiv').hide();



    var radioButtons = $("input[name='OrderTypeRadio']");

    // this should contain the count of all your radio buttons
    //var totalFound = radioButtons.length;

    // this should contain the checked one
    var checkedRadioButton = $("input[name='OrderTypeRadio']:checked");

    //alert(checkedRadioButton);
    // this should get the index of the found radio button based on the list of all
    var selectedIndex = radioButtons.index(radioButtons.filter(':checked'));
    selectedIndex.index(0);

    $("input:radio[name='radioFieldName']:checked").data('index');
   // $("input[name='OrderTypeRadio']:checked").index(0);


    //$('#dialog').fadeOut(100);
    // $('#' + BlocksDropDownList).hide();
    //$('#BlockDiv').hide();

}





