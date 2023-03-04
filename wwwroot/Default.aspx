<%@ Page Language="C#" MasterPageFile="~/MasterPageAJAX.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AJAX" ValidateRequest="false" EnableEventValidation="false" Theme="Portal" %>
<%@ MasterType VirtualPath="~/MasterPageAJAX.master" %>

<%@ Register Assembly="nStuff.UpdateControls" Namespace="nStuff.UpdateControls" TagPrefix="nStuff" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="KFG" %>

<%@ Register src="~/Modules/HotNews/HotNews.ascx" tagname="HotNews" tagprefix="KFG" %>
<%@ Register src="~/Modules/Mid/Mid.ascx" tagname="Mid" tagprefix="KFG" %>
<%@ Register src="~/Modules/Banner/Banner.ascx" tagname="Banner" tagprefix="KFG" %>
<%@ Register src="~/Modules/Left/Left.ascx" tagname="Left" tagprefix="KFG" %>

<%@ Register src="Modules/Menu/Menu.ascx" tagname="Menu" tagprefix="kfg" %>

<%@ Register src="Modules/Customers/Customer_Registration.ascx" tagname="Customer_Registration" tagprefix="KFG" %>

<%@ Register src="Modules/Customers/Customer_Login.ascx" tagname="Customer_Login" tagprefix="KFG" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
   
    <KFG:HotNews ID="HotNewsControl" runat="server" />

  <div class="Container_Mid_Box FloatLeft">
        <KFG:Banner ID="UC_BannerMid" runat="server" />
        
    </div>

    <div class="Container_Right_Box FloatRight">

        <KFG:Customer_Login ID="Customer_LoginControl" runat="server" />
    </div>

    <div class="Container_Bottom_Box">

    <div class="FloatLeft PaddingRight10">
        <KFG:Menu ID="MenuLeftControl" runat="server" />
        <KFG:Banner ID="BannerLeftBottomControl" runat="server" /> 
    </div>

    <div class="FloatLeft PaddingRight5">
        <KFG:Left ID="MidControl" runat="server" />
    </div>

    <div class="FloatLeft PaddingRight5">
        <KFG:Left ID="RightControl" runat="server" />
    </div>

    <div class="FloatLeft PaddingRight5">
        <KFG:Left ID="LeftControl" runat="server" />
    </div>

    </div>
    
    <KFG:Banner ID="UC_BannerMid_Bottom" runat="server" />
    
    <%--<KFG:Customer_Registration ID="Customer_RegistrationControl" runat="server" />--%>
    
    </asp:Content>






