<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Signup_Details.ascx.cs" Inherits="Admin.Admin.Controls.Signup.Signup_Details" %>

<div class="Div_Row">
<asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>
<asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
</div>

<div class="Div_Row">
<asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
<asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
</div>

<div class="Div_Row">
<asp:Label ID="Label2" runat="server" Text="DateofBirth:"></asp:Label>
<asp:TextBox ID="DateofBirthTextBox" runat="server"></asp:TextBox>
</div>

<div class="Div_Row">

    <asp:Label ID="Label5" runat="server" Text="RestaurentName:"></asp:Label>
    <asp:DropDownList ID="RestaurentNameDropDownList" runat="server">
    </asp:DropDownList>

</div>

<div class="Div_Row">
<asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
<asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
</div>

<div class="Div_Row">
<asp:Label ID="Label4" runat="server" Text="PostCode:"></asp:Label>
<asp:TextBox ID="PostCodeTextBox" runat="server"></asp:TextBox>
</div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />