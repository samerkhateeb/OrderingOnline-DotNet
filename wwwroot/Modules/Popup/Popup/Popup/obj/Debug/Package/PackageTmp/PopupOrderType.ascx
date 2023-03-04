<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PopupOrderType.ascx.cs" Inherits="Popup.PopupOrderType" %>
<%--<link href="/Modules/Popup/css/StyleSheet.css" rel="stylesheet" type="text/css" />--%>
<script src="/Modules/Popup/scripts/Popup.js" type="text/javascript"></script>
<%--<a href="http://www.google.com#dialog" name="modal">Simple Window Modal</a>--%>
<div id="boxes">

<div id="dialog" class="window">
        <asp:Label ID="Label3" CssClass="Popup_OrderType_Header" runat="server" Text="Choose Order Type:"></asp:Label>
        <div class="Popup_OrderType_Body">
    <div class="Popup_OrderType_Div">
        <input  name="OrderTypeRadio" value="HD" title="Home Delivery"  type="radio" checked /> 
        <asp:Label ID="Label4" CssClass="Popup_OrderType_Label" runat="server" Text="Home Delivery"></asp:Label>
    </div>
    <br class="ClearBoth" />

    <div class="Popup_OrderType_Div">
        <input  name="OrderTypeRadio" value="PU"  title="Pick Up" type="radio" />
        <asp:Label ID="Label5" CssClass="Popup_OrderType_Label" runat="server" Text="Pick Up"></asp:Label>
    </div>
    <br class="ClearBoth" />
    <div id="GridDiv" class="Hide">
        <div class="Popup_OrderType_Div">
            <asp:Label ID="Label1" runat="server" CssClass="Popup_OrderType_Label" Text="Area: "></asp:Label>
            <select id="LocationsDropDownList" class="Popup_OrderType_DropDownList" runat="server"></select>
            <select id="GridAllDropDownList" class="Hide" runat="server" ></select>
            
        </div>
       <%-- <div id="BlockDiv" class="Popup_OrderType_Div Hide">
            <asp:Label ID="Label2" runat="server" CssClass="Popup_OrderType_Label" AssociatedControlID="BlocksDropDownList" Text="Blocks:"></asp:Label>
            <select id="BlocksDropDownList" class="Popup_OrderType_DropDownList" runat="server" ></select>
            <select id="BlocksFullDropDownList" runat="server" class="Hide"></select>

            <select id="LocationsDropDownList" runat="server" class="Popup_OrderType_DropDownList"></select>

        </div>--%>
    </div>
    <br class="ClearBoth" />
<a href="#" id="SelectOrderType" class="Popup_OrderType_LinkButton">Select</a>

<a href="#" id="CancelOrderType" class="Popup_OrderType_LinkButton">Cancel</a>

</div>
</div>
  
<!-- Mask to cover the whole screen -->
  <div id="mask"></div>
</div>

