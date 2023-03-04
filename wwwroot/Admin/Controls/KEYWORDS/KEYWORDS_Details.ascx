<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KEYWORDS_Details.ascx.cs" Inherits="Admin.Admin.Controls.KEYWORDS.KEYWORDS_Details" %>


<div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
</div>

   <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="SubPageID:" 
            AssociatedControlID="SPIDTextBox"></asp:Label>
    <asp:TextBox ID="SPIDTextBox" runat="server"></asp:TextBox>
     
</div>

    
<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="PageID:" 
            AssociatedControlID="PIDTextBox"></asp:Label>
    <asp:TextBox ID="PIDTextBox" runat="server"></asp:TextBox>
     
</div>


   
<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
