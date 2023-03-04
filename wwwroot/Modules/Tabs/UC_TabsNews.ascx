<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_TabsNews.ascx.cs" Inherits="Portals_Controls_UC_TabsNews" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="Plex" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<br />
<Plex:TabContainer ID="NewsTabContainer" CssClass="Plex__Tab" runat="server" ActiveTabIndex="0" 
    Width="100%"  >
    <Plex:TabPanel runat="server" ID="TabPanel1" Width="100%" Height="100%" Visible="false">
        <ContentTemplate>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" RepeatColumns="5" 
                Width="100%" Height="100%" >
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>'
                        ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
            
                
                </div></ItemTemplate>
                </asp:DataList>
        </ContentTemplate>
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel2" runat="server" Width="100%" Height="100%" Visible="false">
        <ContentTemplate>
             <asp:DataList ID="DataList2" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
              <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>'
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
        </ContentTemplate>
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel3" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList3" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel4" runat="server" Visible="false" >
    <ContentTemplate>
         <asp:DataList ID="DataList4" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Eval("Thumbnail")) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel5" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList5" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Eval("Thumbnail")) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    <Plex:TabPanel ID="TabPanel6" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList6" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    
     <Plex:TabPanel ID="TabPanel7" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList7" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    
     <Plex:TabPanel ID="TabPanel8" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList8" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    
     <Plex:TabPanel ID="TabPanel9" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList9" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    
     <Plex:TabPanel ID="TabPanel10" runat="server" Visible="false">
    <ContentTemplate>
         <asp:DataList ID="DataList10" runat="server" DataKeyField="ID" RepeatColumns="5" Width="100%" >
          <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            <div class="TabsContainer"><div class="TabsDiv">
            
                <div class="TabsImageDiv">
                     <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                    <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("../{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' 
                    ToolTip='<%#Eval("Description") %>' runat="server" />
                    
                    </asp:HyperLink>
                </div>
                
                <div class="TabsTextDiv">
                 <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"></asp:HyperLink>
                    <%--<asp:Label ID="DescriptionLabel" runat="server" Text='<%#Pages_BLL.FilterDescriptionText(Eval("Description"),50) %>'></asp:Label>--%>
                </div>
                
               
            </div>
                
                </div></ItemTemplate>
                </asp:DataList>
    </ContentTemplate>
    </Plex:TabPanel>
    
    
    
</Plex:TabContainer>



