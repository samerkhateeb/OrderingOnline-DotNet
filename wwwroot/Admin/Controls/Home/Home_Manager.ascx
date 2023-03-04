<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Home_Manager.ascx.cs" Inherits="Admin.Admin.Controls.Manage.Home_Manager" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="Plex" %>
    
     <Plex:CollapsiblePanelExtender ID="SettingsPanel_CollapsiblePanelExtender"  runat="server"
        CollapsedSize="0"
        CollapsedText="Show Details"
        ExpandedSize="400" 
        ExpandedText="Hide Details"
        TargetControlID="SettingsPanel" 
        TextLabelID="SettingsHeaderLabel"
        CollapseControlID="SettingsHeaderPanel" 
        ExpandControlID="SettingsHeaderPanel"
        SuppressPostBack="True" 
        ImageControlID="SettengsHeaderImage"
        CollapsedImage="~/App_Themes/ControlPanelSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="~/App_Themes/ControlPanelSkin/CssImages/CollapseIcon.gif"
        >
    </Plex:CollapsiblePanelExtender>
    
    
    <asp:Panel ID="SettingsHeaderPanel" runat="server" SkinID="HomePanelHeaderCollaps">
        <asp:Image ID="SettengsHeaderImage" runat="server" Width="14" Height="14" />
        Control Panel...(<asp:Label ID="SettingsHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="SettingsPanel" runat="server" SkinID="LabelHeader">
        <asp:DataList ID="SettingsDataList" runat="server" Width="85%" RepeatLayout="Flow" 
                      RepeatColumns="100" DataKeyField="Control_ID" >
            <ItemTemplate>
                 <div class="SettengsDiv FloatLeft">
                <a href='<%#  URL.Home_GetLink(Eval("Control_ID"), Eval("Control_ChildID")) %>'>
                    <img src='<%# ConfigurationManager.AppSettings["AssetsMainFolder"] + "/" + ConfigurationManager.AppSettings["AdminFolder"] + "/" + Eval("Control_Thumbnail")%>' height="45px" width="45px" border="0" title='<%# Eval("Control_Description") %>' />
                </a>
                <div class="SettengsText">
                    <a href='<%# URL.Home_GetLink(Eval("Control_ID"), Eval("Control_ChildID")) %>'>'<%# Eval("Control_Name") %>'</a>
                </div>
                   <%--  <div>
                                <asp:ImageButton ID="PageIcon0" runat="server" 
                                    AlternateText='<%# Eval("Control_Description") %>' 
                                    CommandName='<%# Eval("Control_Path") %>' Height="45px" 
                                    ImageUrl='<%# Eval("Control_Thumbnail") %>' Width="45px" />
                        </div>
                        <div class="SettengsText">
                                <asp:LinkButton ID="SettengsLinkButton" runat="server" 
                                    CommandName='<%# Eval("Control_Path") %>' SkinID="NoSkin" 
                                    Text='<%# Eval("Control_Name") %>'></asp:LinkButton>
                        </div>--%>
                    </div>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
   
    
    
 <%--   <Plex:CollapsiblePanelExtender ID="PageCollapsiblePanelExtender" runat="server" 
        CollapsedSize="0" CollapsedText="Show Details" ExpandedSize="300" 
        ExpandedText="Hide Details" TargetControlID="PagesPanel" 
        TextLabelID="PagesHeaderLabel" CollapseControlID="PagesHeaderPanel" 
        ExpandControlID="PagesHeaderPanel" SuppressPostBack="True" 
        ImageControlID="PagesHeaderImage"
        CollapsedImage="~/App_Themes/ControlPanelSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="~/App_Themes/ControlPanelSkin/CssImages/CollapseIcon.gif"
        >
    </Plex:CollapsiblePanelExtender>
    
    <asp:Panel ID="PagesHeaderPanel" runat="server" SkinID="CollapsPanelSkin">
        <asp:Image ID="PagesHeaderImage" runat="server" Width="14" Height="14" />
        Pages Panel...(<asp:Label ID="PagesHeaderLabel" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="PagesPanel" runat="server">
        <asp:DataList ID="PortalPages_DataList" runat="server" DataKeyField="Page_ID" 
             RepeatColumns="5">
            <ItemTemplate>
            
                <div class="PagesDiv FloatLeft">
                   
                            <div class="FloatLeft">
                                <asp:ImageButton ID="PageIcon" runat="server" 
                                    CommandName='<%# Eval("Page_TypeID") %>' 
                                    ImageUrl='<%# Eval("Page_Icon") %>' CssClass="PagesThumbnail" />
                                </div>
                                
                                <div class="PagesTextDiv FloatLeft">
                                    <asp:LinkButton ID="DefaultPageLinkButton" runat="server" SkinID="NoSkin"
                                        CommandName='<%# Eval("Page_TypeID") %>' 
                                        Text='<%# Eval("Page_TitleEng") %>' ></asp:LinkButton><br />
                                    <asp:Label ID="DescriptionLabel" runat="server" SkinID="NoSkin"
                                        Text='<%# Eval("Page_DescriptionEng") %>' CssClass="PagesTextDiv"></asp:Label>
                                </div>
                </div>
                
                
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    
    
<asp:Button ID="Button1" runat="server" Text="Button" />
--%>
    
    
