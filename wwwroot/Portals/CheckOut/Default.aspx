<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_CheckOut_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="../../Modules/CheckOut/CheckOut.ascx" tagname="CheckOut" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <uc1:CheckOut ID="CheckOutControl" runat="server" />
</asp:Content>

