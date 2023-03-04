<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShortNews_Details.ascx.cs" Inherits="Admin.Admin.Controls.ShortNews.ShortNews_Details" %>


    <%@ Register src="../MediaUpload/MediaUpload.ascx" tagname="MediaUpload" tagprefix="uc1" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="NameEng:" 
            AssociatedControlID="NameEngTextBox"></asp:Label>
    <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameEngTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    
        <asp:Label ID="Label10" runat="server" Text="NameArb:"></asp:Label>
        <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
    
    </div>


    
    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="AutoStart:" 
            AssociatedControlID="AutoStartCheckBox"></asp:Label>
    <asp:CheckBox ID="AutoStartCheckBox" runat="server"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="MediaFile:" 
            AssociatedControlID="MediaFileUpload"></asp:Label>
    
        <uc1:MediaUpload ID="MediaFileUpload" runat="server" />
    
    </div>

    
    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Description:" 
            AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>


<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
