<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FastNews_Details.ascx.cs" Inherits="Admin.Admin.Controls.FastNews.FastNews_Details" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="NameEng :" 
            AssociatedControlID="NameEngTextBox"></asp:Label>
    <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameEngTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="NameArb :" AssociatedControlID="NameArbTextBox"></asp:Label>
    <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Labe8" runat="server" Text="Status :" AssociatedControlID="StatusCheckBox"></asp:Label>
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

