<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VotingAnswers_Details.ascx.cs" Inherits="Admin.Admin.Controls.VotingAnswers.VotingAnswers_Details" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="VQuestion ID:" 
            AssociatedControlID="QuestionsDropDownList"></asp:Label>
    <asp:DropDownList ID="QuestionsDropDownList" runat="server"></asp:DropDownList>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="NameEng:" 
            AssociatedControlID="NameEngTextBox"></asp:Label>
    <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="NameArb:" 
            AssociatedControlID="NameArbTextBox"></asp:Label>
    <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="AVG:" 
            AssociatedControlID="AVGTextBox"></asp:Label>
    <asp:TextBox ID="AVGTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Total:" 
            AssociatedControlID="TotalTextBox"></asp:Label>
    <asp:TextBox ID="TotalTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
