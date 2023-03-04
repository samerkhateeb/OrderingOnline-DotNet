<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Drinks_Details.ascx.cs" Inherits="Admin.Admin.Controls.Drinks.Drinks_Details" %>

<div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="NameEng:" AssociatedControlID="NameEngTextBox"></asp:Label>
    <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="NameEng:" AssociatedControlID="NameArbTextBox"></asp:Label>
    <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
    </div>


    <div class="Div_Row">
<asp:Label ID="Label2" runat="server" Text="GroupID:"></asp:Label><asp:DropDownList
    ID="GroupIDDropDownList" runat="server">
</asp:DropDownList>
</div>

 <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Size:" AssociatedControlID="SizeTextBox"></asp:Label>
    <asp:TextBox ID="SizeTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Price:" AssociatedControlID="PriceTextBox"></asp:Label>
    <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="HD_ItemCode:" AssociatedControlID="HD_ItemCodeTextBox"></asp:Label>
    <asp:TextBox ID="HD_ItemCodeTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="PU_ItemCode:" AssociatedControlID="PU_ItemCodeTextBox"></asp:Label>
    <asp:TextBox ID="PU_ItemCodeTextBox" runat="server"></asp:TextBox>
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