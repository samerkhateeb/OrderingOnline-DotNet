<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StaticControls_Details.ascx.cs" Inherits="Admin.Admin.Controls.StaticControls.StaticControls_Details" %>

<div class="Div_Row">
<asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
<asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
</div>
<br />
<div class="Div_Row">
<asp:Label ID="Label2" runat="server" Text="ControlID:"></asp:Label>
<asp:DropDownList ID="ControlIDDropDownList" runat="server">
</asp:DropDownList>
</div>
 <br />

 <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
    <asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />