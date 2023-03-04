var ItemID, 
    QuantityDropDownList,
    ItemName,
    ItemSorting,
    Price,
    PriceMQuantity,
    Total,
    TypeName,
    Quantity,
    RowID, OrderNewRow = "",
    ArrayItems = {},
    ArrayIndex = 0,
    deliveryCharge,
    ArraySize = 0,
    CookieStatus = true,
    NoteTextBox, OrderType;


// load
$(function () {
    // alert(deliveryCharge);

    OrderType = $.cookie("OrderType");
    if (OrderType == "HD")
        $("#DeliveryCharge").html(String.Format("Delivery Charge: {0}", deliveryCharge.toFixed(3)));
    else {
        deliveryCharge = 0;
        $("#DeliveryCharge").hide();
    }

    $('#' + NoteTextBox).keyup(function () {
        var txtClone = $(this).val();
        $('#NoteTextBox2').html(txtClone);
    });


    //alert($.cookie("ItemID0"));

    if ($.cookie("Size") != null && $.cookie("Size") != 0) {
        var i = 0;
        CookieStatus = false;
        ArraySize = parseInt($.cookie("Size"));

        while ($.cookie("ItemID" + i) != null) {

            ItemID = $.cookie("ItemID" + i);
            ItemName = $.cookie("ItemName" + i);
            TypeName = $.cookie("TypeName" + i);
            Quantity = $.cookie("Quantity" + i);
            Price = $.cookie("Price" + i);
            PriceMQuantity = $.cookie("PriceMQuantity" + i);
            ItemSorting = $.cookie("ItemSorting" + i);
            SaveOrder(ItemSorting);
            i++;
            //   ArrayIndex++;
        }

        $("#OrderListTotal").html(GetTotal());

    }



});



function AddOrder(ID) {

    ItemID = ID;
    // Get RowID Value
    RowID = $('#RowIDHidden' + ID).val();

    // Get SubPage ID
    //subpageID = $('#IDHidden' + RowID).val();
    ItemName = $('#ItemName' + ID).html();
    // save data to cookie
    CookieStatus = true;

    for (var i = 0; i < 4; i++) {
        ItemSorting = i+1;

        var QuantityDropDownList = $('#ItemQuantity' + RowID + ItemSorting);
        if (QuantityDropDownList != null && QuantityDropDownList.val() != null && QuantityDropDownList.val() != "0") {

            Quantity = QuantityDropDownList.val();
            Price = parseFloat($('#ItemPrice' + RowID + ItemSorting).html());

            PriceMQuantity = parseFloat(Price * Quantity);

            TypeName = $('#ItemTypeName' + RowID + ItemSorting).html();
            SaveOrder();
            // reset value
            QuantityDropDownList.val('0');

        }
    };
   
    $("#OrderListTotal").html(GetTotal());

}


function SaveOrder() {

    // Clear the Body
    if (ArrayIndex == 0) 
        $('#OrderListBody').html("");

    // Increase Array Size
        ArraySize++;

    // Save To Cookie
    if (CookieStatus)
        SaveCookie();

    // reset array Value
    SaveArray();



    // add the order on the div
    OrderNewRow = String.Format("<div id='Row{0}{5}' class='OrderList_Row'>"
                                + "<div class='OrderList_DivLeft'>{1}, {2}</div>"
                                + "<div class='OrderList_DivMid'>{3}</div>"
                                + "<div id='summaryPriceMQuantity{0}' class='OrderList_DivRight'>{4}</div>"
                                + "</div>", ItemID, ItemName, TypeName, Quantity, parseFloat(PriceMQuantity).toFixed(3), ItemSorting
                                )

    $('#OrderListBody').append(OrderNewRow);
}

function GetTotal() {
    Total = 0;
   
    $.each(ArrayItems, function (i) {
        Total = Total + parseFloat(this["PriceMQuantity"])
    });
    return (Total + deliveryCharge).toFixed(3);

}

function CancelOrder() {
    if (ArrayIndex != 0 && confirm('Are You Sure You Want To Cancel The Order List')) {
        $('#OrderListBody').html("Your Cart Is Empty");
        ClearCookie();
        $('#OrderListTotal').html("0.000")
        ArrayIndex = 0;
        ArraySize = 0;
        ArrayItems = [];
        Total = 0;

        

    }

}

function CheckOut() {
    if (ArrayIndex != 0) {
        $.cookie("GeneralNote", $("#NoteTextBox2").text(), { expires: 7, path: '/' });
        
        window.location.href = '/Portals/CheckOut/';

    }

}

function SaveArray() {
    ArrayItems[ArrayIndex] = [];
    ArrayItems[ArrayIndex]["ID"] = ItemID;
    ArrayItems[ArrayIndex]["Quantity"] = Quantity;
    ArrayItems[ArrayIndex]["PriceMQuantity"] = PriceMQuantity;
   // alert("arrayindex:" + ArrayItems[0]["PriceMQuantity"]);
    ArrayIndex++;
}

function SaveCookie() {

    $.cookie("ItemID" + ArrayIndex, ItemID, { expires: 7, path: '/' });
    $.cookie("ItemName" + ArrayIndex, ItemName, { expires: 7, path: '/' });
    $.cookie("TypeName" + ArrayIndex, TypeName, { expires: 7, path: '/' });
    $.cookie("Quantity" + ArrayIndex, Quantity, { expires: 7, path: '/' });
    $.cookie("PriceMQuantity" + ArrayIndex, PriceMQuantity, { expires: 7, path: '/' });
    $.cookie("Price" + ArrayIndex, Price, { expires: 7, path: '/' });
    $.cookie("ItemSorting" + ArrayIndex, ItemSorting, { expires: 7, path: '/' });
    $.cookie("Size", ArraySize, { expires: 7, path: '/' });
}

function ClearCookie() {

    var i = 0;
        while ($.cookie("ItemID" + i) != null) {

            $.cookie("ItemID" + i, null, { expires: 7, path: '/' });
            $.cookie("ItemName" + i, null, { expires: 7, path: '/' });
            $.cookie("TypeName" + i, null, { expires: 7, path: '/' });
            $.cookie("Quantity" + i, null, { expires: 7, path: '/' });
            $.cookie("ItemSorting" + i, null, { expires: 7, path: '/' });
            $.cookie("Size", null, { expires: 7, path: '/' });
            i++;
        }
    
}





