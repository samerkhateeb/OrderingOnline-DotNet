<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_TabsLeft.ascx.cs" Inherits="Portals_Controls_UC_TabsLeft" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="Plex" %>

<asp:GridView ID="ParentGridView" runat="server" AutoGenerateColumns="False"
ShowFooter="false" Width="230px" ShowHeader="False" DataKeyNames="ParentID" >
    <Columns>
        <asp:TemplateField>
           
            <ItemTemplate>
            
                
                <Plex:TabContainer ID="TabLeftContainer" CssClass="Plex__Tab" runat="server" ActiveTabIndex="0" Width="230"  >
    <Plex:TabPanel runat="server" ID="TabPanel1" Width="100%" Height="100%" Visible="false">
        
        <ContentTemplate>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" RepeatColumns="1" 
                Width="100%" Height="100%" ShowHeader="False" ShowFooter="true">
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                
                
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                
                
                <ItemTemplate>
            
                <div class="MostContainer">
                    <div class="MostDivText">
                     <asp:HyperLink ID="TabsHyperLink" Text ='<%# Eval("Title") %>'
                                        NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                        runat="server" SkinID="ItemLinkButtonSkin"></asp:HyperLink>
                        </div>
                </div>
                
                </ItemTemplate>
                </asp:DataList>
                
                <asp:DataList ID="DataList1Image" runat="server" DataKeyField="ID" RepeatColumns="1" 
                Width="100%" Height="100%" ShowFooter="True" ShowHeader="True">
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                <ItemTemplate>
            
                
                        <asp:Image ID="ThumbnailImage" ImageUrl='<%#String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' SkinID="NoSkin" CssClass="LeftContainerImage" runat="server" />
                        
                        <div class="FlatRight">
                            <asp:HyperLink ID="LeftHyperLink" CssClass="LeftContainerItem" SkinID="NoSkin" runat="server" 
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    Text='<%# Eval("Title") %>'></asp:HyperLink>
                        </div>
                        <hr />
                
                
                </ItemTemplate>
                </asp:DataList>
                
                <div class="ContainerFooterDiv">
                        <div class="FloatLeft">
                            <asp:HyperLink ID="More1HyperLink" runat="server">
                                <img style="border:solid 0px #333;" src="../Themes/CssImages/more_link.gif" />
                            </asp:HyperLink>
                        </div>

                        <div class="FloatRight">
                            <img src="../Themes/CssImages/Container_Footer_right.gif" />
                        </div>
                </div>
                            
                
        </ContentTemplate>
        
        
        
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel2" runat="server" Width="100%" Height="100%" Visible="false">
        
        
        
        <ContentTemplate>
             <asp:DataList ID="DataList2" runat="server" DataKeyField="ID" RepeatColumns="1" Width="100%" >
              <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                
                <ItemTemplate>
                
            <div class="MostContainer">
                    <div class="MostDivText">
                     <asp:HyperLink ID="TabsHyperLink" Text ='<%# Eval("Title") %>'
                                        NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                        runat="server" SkinID="ItemLinkButtonSkin"></asp:HyperLink>
                        </div>
                </div>
                
                </ItemTemplate>
                </asp:DataList>
                
                <asp:DataList ID="DataList2Image" runat="server" DataKeyField="ID" RepeatColumns="1" 
                Width="100%" Height="100%" ShowHeader="False" ShowFooter="true">
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                
                <ItemTemplate>
            
                <div class="LeftContainerDiv">
                        <asp:Image ID="ThumbnailImage" ImageUrl='<%#String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' SkinID="NoSkin" CssClass="LeftContainerImage" runat="server" />
                        
                        <div class="FlatRight">
                            <asp:HyperLink ID="LeftHyperLink" CssClass="LeftContainerItem" SkinID="NoSkin" runat="server" 
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    Text='<%# Eval("Title") %>'></asp:HyperLink>
                        </div>
                        <br />
                        <hr />
                </div>
                
                </ItemTemplate>
                </asp:DataList>
                    
                    <div class="ContainerFooterDiv">
                        <div class="FloatLeft">
                            <asp:HyperLink ID="More2HyperLink" runat="server">
                                <img style="border:solid 0px #333;" src="../Themes/CssImages/more_link.gif" />
                            </asp:HyperLink>
                        </div>

                        <div class="FloatRight">
                            <img src="../Themes/CssImages/Container_Footer_right.gif" />
                        </div>
                </div>
                
                
        </ContentTemplate>
        
        
        
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel3" runat="server" Visible="false">
        
        
    <ContentTemplate>
         <asp:DataList ID="DataList3" runat="server" DataKeyField="ID" RepeatColumns="1" Width="100%" ShowFooter="true" ShowHeader="False">
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />                
                
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                
                <ItemTemplate>
            <div class="MostContainer">
                    <div class="MostDivText">
                     <asp:HyperLink ID="TabsHyperLink" Text ='<%# Eval("Title") %>'
                                        NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                        runat="server" SkinID="ItemLinkButtonSkin"></asp:HyperLink>
                        </div>
                </div>
                
                    </ItemTemplate>
                </asp:DataList>
                
                <asp:DataList ID="DataList3Image" runat="server" DataKeyField="ID" RepeatColumns="1" 
                Width="100%" Height="100%" ShowHeader="False" ShowFooter="true">
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                
                <FooterTemplate>
                &nbsp;
                </FooterTemplate>
                
                
                <ItemTemplate>
            
                <div class="LeftContainerDiv">
                        <asp:Image ID="ThumbnailImage" ImageUrl='<%#String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' SkinID="NoSkin" CssClass="LeftContainerImage" runat="server" />
                        
                        <div class="FlatRight">
                            <asp:HyperLink ID="LeftHyperLink" CssClass="LeftContainerItem" SkinID="NoSkin" runat="server" 
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    Text='<%# Eval("Title") %>'></asp:HyperLink>
                        </div>
                        <br />
                        <hr />
                </div>
                
                </ItemTemplate>
                </asp:DataList>                    
                    
                    <div class="ContainerFooterDiv">
                        <div class="FloatLeft">
                            <asp:HyperLink ID="More3HyperLink" runat="server">
                                <img style="border:solid 0px #333;" src="../Themes/CssImages/more_link.gif" />
                            </asp:HyperLink>
                        </div>

                        <div class="FloatRight">
                            <img src="../Themes/CssImages/Container_Footer_right.gif" />
                        </div>
                    </div>
                
                    
    </ContentTemplate>
        
        
        
    </Plex:TabPanel>
    
</Plex:TabContainer>


            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
