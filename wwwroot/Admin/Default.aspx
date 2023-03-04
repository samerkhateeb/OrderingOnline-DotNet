<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" Theme="AdminSkin" ValidateRequest="false" EnableEventValidation="false" AutoEventWireup="true" Inherits="ControlPanel_Default" Title="Untitled Page"  Codebehind="Default.aspx.cs" %>

<%@ Register src="Controls/SiteMap/SiteMap.ascx" tagname="SiteMap" tagprefix="uc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">
    
    
  
    
    <asp:HiddenField ID="ControlNameHiddenField" runat="server" />
    <uc1:SiteMap ID="SiteMap1" runat="server" />
    <asp:Panel ID="LoadPanel" runat="server">
    </asp:Panel>
    
    
  
    
    
    </asp:Content>

