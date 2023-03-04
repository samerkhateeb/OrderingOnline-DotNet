<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Types_Details.ascx.cs" Inherits="Admin.Admin.Controls.Types.Types_Details" %>



    <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Description:" 
            AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area"  ></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Meta:" 
            AssociatedControlID="MetaTextBox"></asp:Label>
    <asp:TextBox ID="MetaTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label2" runat="server" Text="Page:" AssociatedControlID="PageCheckBox"></asp:Label>
    <asp:CheckBox ID="PageCheckBox" runat="server"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label4" runat="server" Text="Subpage:" AssociatedControlID="SubpageCheckBox"></asp:Label>
    <asp:CheckBox ID="SubpageCheckBox" runat="server"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Category:" AssociatedControlID="CategoryCheckBox"></asp:Label>
    <asp:CheckBox ID="CategoryCheckBox" runat="server"></asp:CheckBox>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
