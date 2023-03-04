<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMap.ascx.cs" Inherits="Admin.Admin.Controls.SiteMap.SiteMap" %>
<%--<asp:Literal ID="SiteMapLiteral" runat="server"></asp:Literal>--%>
<asp:HyperLink ID="HomeHyperLink" runat="server" 
    NavigateUrl="~/admin/Default.aspx">Home</asp:HyperLink>
<br />
<asp:Panel ID="SuperParentPanel" runat="server" Visible="False">
<asp:Label ID="SuperParentLabel" runat="server" Text="SParent"></asp:Label>
<br />
</asp:Panel>
<panel ID="ParentPanel" runat="server" Visible="False">
<asp:HyperLink ID="ParentHyperLink" runat="server"></asp:HyperLink>
<br />
</panel>
<asp:HyperLink ID="ControlHyperLink" runat="server" 
    NavigateUrl="Eval(&quot;Control_ID&quot;)">Control</asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink3" runat="server">HyperLink</asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink4" runat="server">HyperLink</asp:HyperLink>
