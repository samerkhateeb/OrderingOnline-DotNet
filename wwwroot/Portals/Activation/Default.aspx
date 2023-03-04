<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_Activation_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="../../Modules/Customers/Customer_Activation.ascx" tagname="Customer_Activation" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <uc1:Customer_Activation ID="Customer_Activation1" runat="server" />
</asp:Content>

