<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Modules_SuccessCheckOut_Default" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">

    <asp:Label ID="Label1" runat="server" CssClass="Success_Label" Text="Your order has been successfully received. <br /> Please allow us 45 minutes to deliver your order "></asp:Label>
    <a href='<%= ConfigurationManager.AppSettings["WebsiteUrl"].ToString() %>' class="Success_GoToHome" >Go To Home</a>

    </asp:Content>

