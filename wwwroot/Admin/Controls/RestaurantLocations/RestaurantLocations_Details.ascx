<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RestaurantLocations_Details.ascx.cs" Inherits="Admin.Admin.Controls.RestaurantLocations.RestaurantLocations_Details" %>


<div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
 </div>

  <div class="Div_Row">
    <asp:Label ID="Label24" runat="server" Text="Status:" 
            AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label21" runat="server" Text="InLondon:" 
            AssociatedControlID="InLondonCheckBox"></asp:Label>
    <asp:CheckBox ID="InLondonCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label27" runat="server" Text="Sorting:" 
            AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>
          
    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="Description:" 
            AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox"  runat="server" TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="PostalCode:" 
            AssociatedControlID="PostalCodeTextBox"></asp:Label>
    <asp:TextBox ID="PostalCodeTextBox" runat="server"></asp:TextBox>
    </div>

     <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
