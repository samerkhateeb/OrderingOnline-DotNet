<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" Theme="Portal" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_CustomerRegistration_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>
<%@ Register src="~/Modules/Customers/Customer_Registration.ascx" tagname="Customer_Registration" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <uc1:Customer_Registration ID="Customer_Registration1" runat="server" />
</asp:Content>

