﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VotingQuestions_Details.ascx.cs" Inherits="Admin.Admin.Controls.VotingQuestions.VotingQuestions_Details" %>


<body style="direction: ltr">


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
    <asp:Label ID="Label1" runat="server" Text="Period:" 
            AssociatedControlID="PeriodTextBox"></asp:Label>
    <asp:TextBox ID="PeriodTextBox" runat="server"></asp:TextBox>
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
