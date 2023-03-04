/// <reference path="jquery-1.7.2.min.js" />

var RegisterGridsDropDownList, RegisterBlocksDropDownList, RegisterGridsFullDropDownList, BlockValue, Register_GridValue, i,
    emptyValue = { "No Block Exist": "0" }, GridFullSelectedValue, GridFullValue, BlockHiddenField,
    BlockArray;





$(function () {


    //    // on DropDownList Change
    $('#' + RegisterGridsDropDownList).change(function (e) {

        if ($(this).val() != "0") {
            FillBlockList($(this).val().toLowerCase());

            //$('#' + RegisterBlocksDropDownList).addOption(BlockArray, false);

            //            $('#BlockDiv').show();
            //            $('#' + RegisterBlocksDropDownList).show();
        }
        else {
            ClearBlockList();
            $('#' + RegisterBlocksDropDownList).append($('<option></option>').val('0').html('No Block Available'));
        }

    });



    $('#' + RegisterBlocksDropDownList).change(function (e) {

        SelectBlockListValue($(this).val());
        //$(BlockHiddenField).val($(this).val());
        // alert($(BlockHiddenField).text());

    });

});


function FillBlockList(selectedValue) {


    i = 0;
    BlockArray = {};
    // refill the data again
    // $('#' + RegisterGridsFullDropDownList).find('option').clone().appendTo('#' + RegisterBlocksDropDownList);

    // filter the options
    $('#' + RegisterGridsFullDropDownList).find('option').each(function () {
        GridFullSelectedValue = $(this).val().toLowerCase();

        GridFullValue = GridFullSelectedValue;

        // Get the first value of the GridFull
        if (GridFullValue.split(' ').length > 0)
            GridFullValue = GridFullValue.split(' ')[0].toLowerCase();

        // Check Register
        if (GridFullValue == selectedValue) {
            //BlockValue =;
            if (GridFullSelectedValue.split(' ').length > 0 && GridFullSelectedValue.split(' ')[1] != null) {
                BlockArray[i] = GridFullSelectedValue.split(' ')[1];
                // else
                // BlockArray[i] = 0;
                i++;
            }
        }
    });
    // Clear Block List
    ClearBlockList();

    if (i == 0) {
        $('#' + RegisterBlocksDropDownList).append($('<option></option>').val('').html('Block Is Empty'));
        $(BlockHiddenField).val("");
    }

    //    $('#' + RegisterBlocksDropDownList).addOption(emptyValue, false);
    else {
        //  BlockArray.sort();
        $.each(BlockArray, function (val, text) {
            $('#' + RegisterBlocksDropDownList).append($('<option></option>').val(text).html(text))
        });

        // Fill the block default value
        $(BlockHiddenField).val(BlockArray[0]);
    }

}




function ClearBlockList() {
    $('#' + RegisterBlocksDropDownList + ' option').each(function (index, option) {
        $(option).remove();
    });
}


function SelectBlockListValue(selectedValue) {

    $(BlockHiddenField).val(selectedValue);
    $('#' + RegisterBlocksDropDownList).val(selectedValue);
}