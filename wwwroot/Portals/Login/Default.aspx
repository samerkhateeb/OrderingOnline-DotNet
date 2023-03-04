<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_Login_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="../../Modules/Customers/Customer_Login.ascx" tagname="Customer_Login" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <div class="MarginCenter">
        <uc1:Customer_Login ID="Customer_LoginControl" runat="server" />
    </div>
</asp:Content>

