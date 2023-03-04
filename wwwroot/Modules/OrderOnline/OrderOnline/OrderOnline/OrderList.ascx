<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderList.ascx.cs" Inherits="OrderOnline.OrderList" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>--%>
<script src="/Modules/OrderOnline/Scripts/OrderList.js" type="text/javascript"></script>
<div class="OrderList_Header">Your Order</div>
<div class="OrderList_Div">
<div class="OrderList_Header2">
    <div class="OrderList_Row">
        <div class="OrderList_Header_DivLeft">Item</div>
        <div class="OrderList_Header_DivMid">QTY</div>
        <div class="OrderList_Header_DivRight">Price</div>
    </div>
</div>

<div id="OrderListBody" class="OrderList_BodyDiv">Your Cart Is Empty</div>
<br class="ClearBoth" />
<div id="DeliveryCharge" class="OrderList_DileveryCharge_Div"></div>

<div class="OrderList_TotalDiv">
    Total: 
    <div id="OrderListTotal" class="FloatRight" >0.000</div>
</div>
<br class="ClearBoth" />
<div class="OrderList_Note_Header" >Notes</div>
<div class="OrderList_Note_Body" >
    <asp:TextBox ID="NoteTextBox" runat="server" CssClass="OrderList_Note_TextBox" TextMode="MultiLine"></asp:TextBox>
    <KFG:TextBoxWatermarkExtender ID="NoteTextBox_TextBoxWatermarkExtender" 
        runat="server" TargetControlID="NoteTextBox" WatermarkCssClass="OrderList_Note_WaterMark" WatermarkText="Please write your notes here...">
    </KFG:TextBoxWatermarkExtender>
    <div class="Hide" id="NoteTextBox2"></div>
</div>
<a href="javascript:;" id="orderListCancel" onclick="CancelOrder();"></a>
<a href="javascript:;" id="orderListCheckOut" onclick="CheckOut();"></a>

</div>