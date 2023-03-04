var ItemID,
    ItemName,
    ItemSorting,
    Price,
    PriceMQuantity,
    Total,
    TypeName,
    Quantity,
    ArrayItems = {},
    deliveryCharge,
    NoteTextBox,
    NoteTextBox2,
    deliveryType;

// load
$(function () {

    deliveryType = $.cookie("OrderType");
    if (deliveryType == "HD")
        $("#DeliveryCharge").html(String.Format("Delivery Charge: {0}", deliveryCharge.toFixed(3)));
    else {
        $("#DeliveryCharge").hide();
        deliveryCharge = 0;
    }




//    $(NoteTextBox).keyup(function () {
//        var txtClone = $(this).val();
//        $(NoteTextBox2).val(txtClone);
//    });




    //    // on CheckOut Click
    $('#CheckOutButton').click(function (e) {

        $(this).attr("disabled", true);
        $(CheckOutLinkButton).click();

      

    });



    //alert($.cookie("ItemID0"));
    if ($.cookie("Size") != null && $.cookie("Size") != "0") {
        var i = 0;
        CookieStatus = false;

        while ($.cookie("ItemID" + i) != null) {

            ItemID = $.cookie("ItemID" + i);
            ItemName = $.cookie("ItemName" + i);
            TypeName = $.cookie("TypeName" + i);
            Quantity = $.cookie("Quantity" + i);
            PriceMQuantity = $.cookie("PriceMQuantity" + i);
            Price = $.cookie("Price" + i);
            ItemSorting = $.cookie("ItemSorting" + i);
            BindOrder(i)
            i++;
        }
        $(NoteTextBox).val($.cookie("GeneralNote"));
        //$(NoteTextBox2).val($.cookie("GeneralNote"));
        
        var total = GetTotal();
        $("#Total").html('Total: ' + total);
        $.cookie("Total", total);
        //$.cookie("GeneralNote", $("#" + NoteTextBox).val());

    }

});


function BindOrder(i) {

    ArrayItems[i] = [];
    ArrayItems[i]["ID"] = ItemID;
    ArrayItems[i]["Quantity"] = Quantity;
    ArrayItems[i]["PriceMQuantity"] = PriceMQuantity;

        // add the order on the div
    OrderNewRow = String.Format("<div class='CheckOut_Body_Row_Div'>"
                                + "<div class='CheckOut_Body_Row_1'>{1}, {2}</div>"
                                + "<div class='CheckOut_Body_Row_2'> <textarea id='TextArea1' cols='20' rows='2' class='CheckOut_Body_Row_Input'></textarea></div>"
                                + "<div class='CheckOut_Body_Row_3'>{3}</div>"
                                + "<div  class='CheckOut_Body_Row_4'>{4}</div>"
                                + "<div  class='CheckOut_Body_Row_5'>{5}</div>"
                                + "</div><br class=ClearBoth />", ItemID, ItemName, TypeName, Quantity, parseFloat(Price).toFixed(3), parseFloat(PriceMQuantity).toFixed(3), i
                                )

        $('#CheckOutBody').append(OrderNewRow);
        
}



function GetTotal() {
    Total = 0;

    $.each(ArrayItems, function (i) {
        Total = Total + parseFloat(this["PriceMQuantity"])
    });
    return (Total + deliveryCharge).toFixed(3);

}

function DisableCheckout() {

    $('#CheckOutButton').attr("disabled", true);
    $('#CheckOutButton').toggleClass("CheckOut_Body_LinkButton_Disable");

}

function EnableCheckout() {

    $('#CheckOutButton').attr("disabled", '');
    $('#CheckOutButton').toggleClass("CheckOut_Body_LinkButton");

}