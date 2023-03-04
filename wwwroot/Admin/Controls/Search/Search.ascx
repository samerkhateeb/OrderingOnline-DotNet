<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="Admin.Admin.Controls.Search.Search" %>


<asp:textbox runat="server" ID="SearchTextBox"></asp:textbox>
<asp:Button runat="server" text="Search" ID="SearchButton" onclick="SearchButton_Click" ></asp:Button>

<br />
<br />

<asp:GridView ID="SubPageGridView" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="SP_ID" 
            DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=20&amp;status=edit" 
            DataTextField="SP_NameEng" HeaderText="Subpages Search Results">
        </asp:HyperLinkField>
    </Columns>
</asp:GridView>



<p>&nbsp;</p>

<asp:GridView ID="CategoryGridView" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="CAT_ID" 
            DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=19&amp;status=edit" 
            DataTextField="CAT_NameEng" HeaderText="Categories Search Results">
        </asp:HyperLinkField>
    </Columns>
</asp:GridView>

<p>&nbsp;</p>

<asp:GridView ID="PageGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField HeaderText="Pages Search Results" 
                DataNavigateUrlFields="Page_ID" 
                DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=5&amp;status=edit" 
                DataTextField="Page_NameEng"></asp:HyperLinkField>
        </Columns>
    </asp:GridView>

<p>&nbsp;</p>

    <asp:GridView ID="TXNGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField HeaderText="Sale TXNs Search Results" 
                DataNavigateUrlFields="SalesTXN_ID" 
                DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=25&amp;status=edit" 
                DataTextField="SalesTXN_VoucherID"></asp:HyperLinkField>
        </Columns>
    </asp:GridView>

<p>&nbsp;</p>

<asp:GridView ID="TXNLineGridView" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:HyperLinkField HeaderText="Sale TXN Lines Search Results" 
            DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=24&amp;status=edit" 
            DataNavigateUrlFields="SalesTXNDetail_ID" DataTextField="SalesTXNDetail_Name"></asp:HyperLinkField>
    </Columns>
</asp:GridView>

<p>&nbsp;</p>

<asp:GridView ID="ModifierGridView" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:HyperLinkField HeaderText="Modifier Search Results" 
            DataNavigateUrlFormatString="~/admin/default.aspx?id={0}&amp;controlid=26&amp;status=edit" 
            DataNavigateUrlFields="Modifier_ID" DataTextField="Modifier_Name"></asp:HyperLinkField>
    </Columns>
</asp:GridView>




