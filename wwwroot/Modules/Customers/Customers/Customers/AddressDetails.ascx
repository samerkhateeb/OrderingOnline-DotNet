<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressDetails.ascx.cs" Inherits="Customer.AddressDetails" %>

<script src="/Modules/Customers/scripts/AddressDetails.js" type="text/javascript"></script>


<div class="Div_Row">
 <asp:Label ID="Label3" runat="server" AssociatedControlID="GridsDropDownList" Text="Area: " CssClass="Label">
    </asp:Label>
    <asp:DropDownList ID="GridsDropDownList"  CssClass="DropDownList" runat="server"  >
    </asp:DropDownList>
</div>

<div class="Div_Row">
 <asp:Label ID="Label4" runat="server" AssociatedControlID="BlockDropDownList" Text="Block:" CssClass="Label"></asp:Label>
    <asp:DropDownList ID="BlockDropDownList" CssClass="DropDownList" runat="server">
        <asp:ListItem Text="--- Select Block ---" Value="0"></asp:ListItem>
    </asp:DropDownList>
     <asp:DropDownList ID="GridsFullDropDownList" CssClass="Hide" runat="server" Height="16px" Width="124px">
     </asp:DropDownList>
</div>
<asp:HiddenField ID="BlockHiddenField" runat="server" />



    <div class="Div_Row">
 <asp:Label ID="Label6" runat="server" AssociatedControlID="StreetTextBox" Text="Street:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="StreetTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>


<div class="Div_Row">
 <asp:Label ID="Label5" runat="server" AssociatedControlID="BuildingTextBox" Text="Building:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="BuildingTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>


<div class="Div_Row">
 <asp:Label ID="Label7" runat="server" AssociatedControlID="FloorTextBox" Text="Floor:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="FloorTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>


<div class="Div_Row">
 <asp:Label ID="Label8" runat="server" AssociatedControlID="FlatTextBox" Text="Flat:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="FlatTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>

<div class="Div_Row">
 <asp:Label ID="Label9" runat="server" AssociatedControlID="AddressOtherTextBox" Text="Other:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="AddressOtherTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>