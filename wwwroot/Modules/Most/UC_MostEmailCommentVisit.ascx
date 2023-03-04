<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_MostEmailCommentVisit.ascx.cs" Inherits="Portals_Controls_UC_MostEmailCommentVisit" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="Plex" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<Plex:TabContainer ID="NewsTabContainer" CssClass="Plex__Tab" runat="server" ActiveTabIndex="2" 
    Width="185px"  >
    <Plex:TabPanel runat="server" ID="VisitTabPanel" HeaderText="Most Visit" Width="90%" Height="100%" Visible="false">
        <ContentTemplate>
            
            <asp:DataList ID="VisitDataList" runat="server" DataKeyField="ID" RepeatColumns="1" 
                Width="90%" Height="100%" CellPadding="0" BorderStyle="None" 
                ShowHeader="False" ShowFooter="False">
                
                <AlternatingItemStyle VerticalAlign="Top" />
                
                <ItemStyle VerticalAlign="Top" />
                
                <ItemTemplate>
            
            <div class="MostContainer">
            
                <div class="MostDivText">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%# Eval("Title") %>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","ItemSource"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server" SkinID="ItemLinkButtonSkin"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            
            
                
                </div></ItemTemplate>
                </asp:DataList>
        </ContentTemplate>
        
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="EmailTabPanel" runat="server" HeaderText="Most Sent" Width="90%" Height="100%" Visible="false">
        <ContentTemplate>
             
             <asp:DataList ID="EmailDataList" runat="server" DataKeyField="ID" 
                 RepeatColumns="1" Width="90%" ShowFooter="False" ShowHeader="False" ><ItemTemplate>
                 
            <div class="MostContainer">
            
                <div class="MostDivText">
                     <asp:HyperLink ID="TabsHyperLink0"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server" SkinID="ItemLinkButtonSkin" 
                         Text='<%# Eval("Title") %>'></asp:HyperLink>
                     <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
                </div>
                
                    </ItemTemplate>                 
                        </asp:DataList>
             
        </ContentTemplate>
        
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="CommentTabPanel" runat="server" HeaderText="Most Comment" Width="90%" Height="100%" Visible="false">
    <ContentTemplate>
         
         <asp:DataList ID="CommentDataList" runat="server" DataKeyField="ID" 
             RepeatColumns="1" Width="90%" ShowFooter="False" ShowHeader="False" ><ItemTemplate>
             
           <div class="MostContainer">
            
                <div class="MostDivText">
                 <asp:HyperLink ID="TabsHyperLink1" Text ='<%# Eval("Title") %>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server" SkinID="ItemLinkButtonSkin"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                </div>
                    </ItemTemplate>
                        </asp:DataList> 
    </ContentTemplate>
        
    </Plex:TabPanel>
    
    
</Plex:TabContainer>



