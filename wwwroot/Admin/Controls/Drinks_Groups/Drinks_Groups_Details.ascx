<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Drinks_Groups_Details.ascx.cs" Inherits="Admin.Admin.Controls.Drinks_Groups.Drinks_Groups_Details" %>

<div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="GroupName:" AssociatedControlID="GroupNameTextBox"></asp:Label>
    <asp:TextBox ID="GroupNameTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="Sorting :" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    
<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
