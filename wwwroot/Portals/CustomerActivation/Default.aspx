<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" Theme="Portal" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_CustomerAuthorization_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="../../Modules/Customers/Customer_Activation.ascx" tagname="Customer_Activation" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <uc1:Customer_Activation ID="Customer_Activation" runat="server" />
</asp:Content>

