<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Grids_Details.ascx.cs" Inherits="Admin.Admin.Controls.Grids.Grids_Details" %>


<div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Code:" 
            AssociatedControlID="CodeTextBox"></asp:Label>
    <asp:TextBox ID="CodeTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="CodeTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
   </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Name:" 
        AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Location Code:" 
        AssociatedControlID="LocationCodeDropDownList"></asp:Label>
        <asp:DropDownList ID="LocationCodeDropDownList" runat="server">
    </asp:DropDownList>
    
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True" />
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row Hide">
        <asp:Label ID="Label4" runat="server" Text="Date:" AssociatedControlID="DateTextBox"></asp:Label>
    <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
    </div>


<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
