<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHome.ascx.cs" Inherits="Admin.Admin.Controls.SearchHome.SearchHome" %>

<div class="HomeSearch_Div FloatRight MarginTop35">
              <asp:textbox ID="SearchTextBox" runat="server" CssClass="HomeSearchTextBox" SkinID="NoSkin">
              </asp:textbox>
              <asp:linkbutton ID="SearchLinkbutton" runat="server" CssClass="SearchLinkButton FloatRight" 
                    SkinID="NoSkin" onclick="Search_Click"></asp:linkbutton>
              
              </div>
