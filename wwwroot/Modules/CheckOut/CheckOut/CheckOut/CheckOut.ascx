<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.ascx.cs" Inherits="CheckOut.CheckOut" %>
<script src="/Modules/checkout/scripts/checkout.js" type="text/javascript"></script>
<%@ Register src="/Modules/Customers/AddressDetails.ascx" tagname="AddressDetails" tagprefix="KFG" %>
<%@ Register src="/Modules/Customers/Customer_Login_Checkout.ascx" tagname="CustomerLogin" tagprefix="KFG" %>
<%@ Register src="/Modules/Customers/Customer_Activation_Checkout.ascx" tagname="CustomerActivation" tagprefix="KFG" %>

<div class="CheckOut_Div">



    <div class="CheckOut_Header_2">Order Summary</div>

        <KFG:CustomerLogin ID="CustomerLoginControl" runat="server" />
        <KFG:CustomerActivation ID="CustomerActivationControl" runat="server" />

    <div class="CheckOut_Header_Div">
        <div class="CheckOut_Header_Div1">Item Name</div>
        <div class="CheckOut_Header_Div2">Special Request</div>
        <div class="CheckOut_Header_Div3">Qty</div>
        <div class="CheckOut_Header_Div4">Price</div>
        <div class="CheckOut_Header_Div5">Total</div>
    </div>
    
    <div id="CheckOutBody" class="CheckOut_Body_Div"></div>
    <br class="ClearBoth" />

    <div id="DeliveryCharge" class="CheckOut_DeliveryCharge_Div"></div>

    <div id="Total" class="CheckOut_Total_Div"></div>

    <div class="CheckOut_Address_Div">
    <div class="CheckOut_Address_Header">Customer Address Details</div>
    
        <KFG:AddressDetails ID="AddressDetailsControl" runat="server" />
    </div>

    <div class="CheckOut_Header_2">General Note</div>
    <asp:TextBox ID="NoteTextBox" runat="server" CssClass="CheckOut_Body_Row_Input_2" TextMode="MultiLine"></asp:TextBox>
    <br class="ClearBoth" />
    <input id="CheckOutButton" type="button" class="CheckOut_Body_LinkButton" />
    <asp:Button ID="CheckServerButton" runat="server" CssClass="Hide" onclick="CheckOutButton_Click"/>



    <%--<asp:HiddenField ID="NoteTextBox2" runat="server" />--%>
    <%--<input type="hidden" id="NoteTextBox2" runat="server" />--%>

</div>