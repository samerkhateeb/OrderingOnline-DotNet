<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Admin_Users_Details.ascx.cs" Inherits="Admin.Admin.Controls.Admin_Users.Admin_Users_Details" %>


 <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="RuleID:" 
            AssociatedControlID="RuleIDDropDownList"></asp:Label>
    <asp:DropDownList ID="RuleIDDropDownList" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="RuleIDDropDownList" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
   </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Name:" 
        AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Description:" 
        AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True" />
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

   
    <div class="Div_Row">
        <asp:Label ID="Label7" runat="server" Text="Password:" AssociatedControlID="PasswordTextBox"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
