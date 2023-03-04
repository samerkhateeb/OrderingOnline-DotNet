<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsBar_Details.ascx.cs" Inherits="Admin.Admin.Controls.NewsBar.NewsBar_Details" %>


    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="TitleEng:" 
            AssociatedControlID="TitleEngTextBox"></asp:Label>
    <asp:TextBox ID="TitleEngTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="TitleArb:" 
            AssociatedControlID="TitleArbTextBox"></asp:Label>
    <asp:TextBox ID="TitleArbTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Link:" 
            AssociatedControlID="LinkTextBox"></asp:Label>
    <asp:TextBox ID="LinkTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" checked="true"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
