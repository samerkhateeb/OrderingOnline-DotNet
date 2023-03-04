<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Comments_Details.ascx.cs" Inherits="Admin.Admin.Controls.Comments.Comments_Details" %>


<%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="uc1" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Source ID:" 
            AssociatedControlID="SourceIDTextBox"></asp:Label>
    <asp:TextBox ID="SourceIDTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="Source Name:" 
            AssociatedControlID="SourceNameTextBox"></asp:Label>
    <asp:TextBox ID="SourceNameTextBox" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="SourceNameTextBox" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Sender NameEng:" 
            AssociatedControlID="SenderNameEngTextBox"></asp:Label>
    <asp:TextBox ID="SenderNameEngTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Sender NameArb:" 
            AssociatedControlID="SenderNameArbTextBox"></asp:Label>
    <asp:TextBox ID="SenderNameArbTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Sender Email:" 
            AssociatedControlID="SenderEmailTextBox"></asp:Label>
    <asp:TextBox ID="SenderEmailTextBox" runat="server"></asp:TextBox>
    </div>

    
    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="BodyEng:" ></asp:Label>
    <uc1:HTMLEditor ID="BodyEngHTMLEditor" runat="server" />
     </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="BodyArb:"></asp:Label>
    <uc1:HTMLEditor ID="BodyArbHTMLEditor" runat="server" />
    </div>

    

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
