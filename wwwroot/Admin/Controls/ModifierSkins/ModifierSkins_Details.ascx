<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ModifierSkins_Details.ascx.cs" Inherits="Admin.Admin.Controls.ModifierSkins.ModifierSkins_Details" %>

<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Name:" 
        AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Path:" 
        AssociatedControlID="PathDropdownlist"></asp:Label>
    <asp:Dropdownlist ID="PathDropdownlist" runat="server"></asp:Dropdownlist>
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

