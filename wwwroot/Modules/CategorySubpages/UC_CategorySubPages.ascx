<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_CategorySubPages.ascx.cs" Inherits="Portals_Controls_UC_CategorySubPages" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<div class="Category_Div FloatRight"> 
<div class="Category_Header_Div">
 <asp:HyperLink ID="RootHyperLink" CssClass="MarginLeft5 Category_Header_LinkButton FloatRight MarginRight5" runat="server"></asp:HyperLink>
    <img id="Img2" class="Arrow_Right FloatRight" src="~/images/spaceball.gif" runat="server" />
    <asp:Label ID="ParentHeaderLabel" CssClass="MarginLeft5 Category_Header_Label FloatRight MarginRight5" runat="server" ></asp:Label>
</div>
<div class="Category_Body_Div FloatRight">
            <asp:Image ID="ParentImage" Hspace="3" runat="server" ImageAlign="Right" />
            <asp:HyperLink ID="HeaderHyperLink" CssClass="Category_Header_LinkButton2" runat="server"></asp:HyperLink>
            <asp:Label ID="HeaderDescriptionLabel" CssClass="Category_Header_Label_Description" runat="server"></asp:Label>
<br class="ClearBoth" />

            <asp:DataList runat="server" RepeatColumns="1" DataKeyField="ID" 
    Width="100%" ID="CategoryDataList" Height="100%" HorizontalAlign="Right" 
                RepeatDirection="Horizontal" >
                <AlternatingItemStyle VerticalAlign="Top" />
                <ItemStyle VerticalAlign="Top" />
                <ItemTemplate>
            
            <div class="Category_Row">
            
                <asp:HyperLink ID="ImageHyperLink"
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server">
                                    
                <asp:Image ID="TabsImage" ImageUrl='<%# String.Format("{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>'
                            ToolTip='<%#Eval("Description") %>' CssClass="Category_Row_Thumbnail FloatRight" runat="server" />
                </asp:HyperLink>
                
                <asp:HyperLink ID="TabsHyperLink" Text ='<%#Eval("Title")%>'
                                    NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                    runat="server"  CssClass="Category_Row_LinkButton FloatLeft">
                </asp:HyperLink>
                <br />
                <asp:Label ID="DescriptionLabel" Text='<%# Pages_BLL.FilterDescriptionText(Eval("Description"),500)%>' CssClass="LabelDescription"  runat="server" ></asp:Label>
                
            </div>
            
</ItemTemplate>
</asp:DataList>
    <hr class="FloatRight" />  
    <br class="ClearBoth" />  


<div class="FloatRight">

        <asp:UpdatePanel ID="CategoryUpdatePanel" runat="server">
        <ContentTemplate>
        
        <asp:GridView ID="CategoryGridView" runat="server"  ShowHeader="true"
                AutoGenerateColumns="False" Width="100%" 
                AllowPaging="False" PageSize="20" 
            onpageindexchanging="CategoryGridView_PageIndexChanging">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                        <div class="CategoryGridLink">
                            <asp:HyperLink ID="CategoryHyperLink" runat="server" CssClass="Container_Right_Body_LinkButton"
                                NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                Text='<%# Eval("Title") %>'></asp:HyperLink>
                        </div>
                        </ItemTemplate>
                        <HeaderTemplate>
                           <asp:Label ID="HeaderLabel" runat="server" CssClass="LabelHeader FloatRight" ></asp:Label>
                        </HeaderTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle CssClass="PagerLink" Font-Names="Rod" Width="70px" />
        </asp:GridView>
        </div>
        
        </ContentTemplate>
    </asp:UpdatePanel>
         <asp:UpdateProgress ID="CategoryUpdateProgress" runat="server" 
            AssociatedUpdatePanelID="CategoryUpdatePanel">
            <ProgressTemplate>

                <div class="FloatRight">
                    <img src="/Images/loading.gif" runat="server" style="width: 16px; height: 16px" />
                </div>

            </ProgressTemplate>
        </asp:UpdateProgress>
    <asp:HiddenField ID="IDHiddenField" runat="server" />
       
    <asp:HiddenField ID="TypeHiddenField" runat="server" />
    <asp:HiddenField ID="SourceHiddenField" runat="server" />

</div>
</div>
</div>