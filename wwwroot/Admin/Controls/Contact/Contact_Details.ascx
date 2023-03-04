<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contact_Details.ascx.cs" Inherits="Admin.Admin.Controls.Contact.Contact_Details" %>


<%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="uc1" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Email:" 
            AssociatedControlID="EmailTextBox"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Side:" 
            AssociatedControlID="SideTextBox"></asp:Label>
    <asp:TextBox ID="SideTextBox" runat="server"></asp:TextBox>
    </div>

    
    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status :" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting :" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Comment:"></asp:Label>
    <uc1:HTMLEditor ID="BodyHTMLEditor" runat="server" />
     </div>


<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
