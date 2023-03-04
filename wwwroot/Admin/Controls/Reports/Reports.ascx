<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Reports.ascx.cs" Inherits="Admin.Admin.Controls.Reports.Reports" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<p>
    <asp:Label ID="Label5" runat="server" Text="Report Type:"></asp:Label>
    <asp:DropDownList ID="XDropDownList" runat="server">
        <asp:ListItem Value="0">Customer</asp:ListItem>
        <asp:ListItem Value="1">Sales</asp:ListItem>
        <asp:ListItem Value="2">All</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Date:"></asp:Label>
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label3" runat="server" Text="From:" SkinID="Labele2"></asp:Label>
        <asp:TextBox ID="DateFromTextBox" runat="server" SkinID="TextBox3" Style="margin-top: 0px"></asp:TextBox>
        <cc1:CalendarExtender ID="DateFromTextBox_CalendarExtender" runat="server" TargetControlID="DateFromTextBox">
        </cc1:CalendarExtender>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" SkinID="Labele2" Text="To:"></asp:Label>
        <asp:TextBox ID="DateToTextBox" runat="server" SkinID="TextBox3" Style="margin-top: 0px"></asp:TextBox>
        <cc1:CalendarExtender ID="DateToTextBox_CalendarExtender" runat="server" TargetControlID="DateToTextBox">
        </cc1:CalendarExtender>
    </asp:Panel>
</p>
<p>
    <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" />
</p>
<p>
    &nbsp;</p>

<asp:Panel ID="CustomerPanel" runat="server" Visible="false">
    <asp:Label ID="CustomerCountLabel" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="CustomerGridView" runat="server">
    </asp:GridView>
    <p>
        &nbsp;</p>
</asp:Panel>

<asp:Label ID="SaleCountLabel" runat="server" Visible="false"></asp:Label>
<asp:Label ID="SaleSumLabel" runat="server" Visible="false"></asp:Label>
<br class="ClearBoth" />
<asp:GridView ID="SalesGridView" runat="server">
</asp:GridView>
