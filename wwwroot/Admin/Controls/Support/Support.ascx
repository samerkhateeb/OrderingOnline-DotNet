<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Support.ascx.cs" Inherits="Admin.Admin.Controls.Support.Support" %>



<%@ Register src="Support_Forms.ascx" tagname="Support_Forms" tagprefix="uc1" %>



<uc1:Support_Forms ID="Support_Forms1" runat="server" />



<asp:GridView ID="ManagerGridView" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Support_ID" HeaderText="ID" />
        <asp:TemplateField HeaderText="Comments">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Support_ID"), Request.QueryString["controlid"]) %>' 
                    Text='<%# Eval("Support_Comment").ToString().Length > 60? Eval("Support_Comment").ToString().Substring(0, 59) + "..." :Eval("Support_Comment").ToString()  %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:BoundField DataField="Support_Date" HeaderText="Date" />
    </Columns>
</asp:GridView>

