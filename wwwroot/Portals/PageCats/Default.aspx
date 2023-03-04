<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_PageCats_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="~/Modules/PageCategories/PageCategories.ascx" tagname="PageCategories" tagprefix="KFG" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">


   

    <KFG:PageCategories ID="PageCategoriesControl" runat="server" />

</asp:Content>

