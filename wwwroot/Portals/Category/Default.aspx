<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Portals_Category_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register src="~/Modules/Category/Category.ascx" tagname="Category" tagprefix="uc1" %>

<%@ Register src="../../Modules/Orderonline/OrderList.ascx" tagname="OrderList" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    <div class="FloatRight">
        <uc2:OrderList ID="OrderListControl" runat="server" />
    </div>
    <div class="FloatLeft">
        <uc1:Category ID="CategoryControl" runat="server" />
    </div>
   

</asp:Content>

