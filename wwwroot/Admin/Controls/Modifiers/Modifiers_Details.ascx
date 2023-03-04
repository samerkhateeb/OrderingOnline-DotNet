<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Modifiers_Details.ascx.cs" Inherits="Admin.Admin.Modifiers.Modifiers_Details" %>


<div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
   </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="ParentID:" 
        AssociatedControlID="ParentIDTextBox"></asp:Label>
    <asp:TextBox ID="ParentIDTextBox" runat="server"></asp:TextBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Description:" 
        AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server" SkinID="TextBox_Area" TextMode="MultiLine"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Price:" 
        AssociatedControlID="PriceTextBox"></asp:Label>
    <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="DineinItemCode:" 
        AssociatedControlID="DineinItemCodeTextBox"></asp:Label>
    <asp:TextBox ID="DineinItemCodeTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="PickupItemCode:" 
        AssociatedControlID="PickupItemCodeTextBox"></asp:Label>
    <asp:TextBox ID="PickupItemCodeTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="CategoryID:" 
        AssociatedControlID="CategoryIDTextBox"></asp:Label>
    <asp:TextBox ID="CategoryIDTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True" />
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />