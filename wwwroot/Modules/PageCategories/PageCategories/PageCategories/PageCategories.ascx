<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageCategories.ascx.cs" Inherits="PageCategories.PageCategories" %>
<%@ Import Namespace="KFGCMS.BLL" %>

    <asp:Label ID="BodyLabel" runat="server"></asp:Label>

            <asp:DataList runat="server" RepeatColumns="3" DataKeyField="ID" ID="CategoryDataList" Height="100%" CellPadding="0" 
                HorizontalAlign="Right" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False">
                <EditItemStyle HorizontalAlign="Right" />
                <AlternatingItemStyle VerticalAlign="Top" HorizontalAlign="Right" />
                <ItemStyle VerticalAlign="Top" HorizontalAlign="Right" />
                <ItemTemplate>
            <div class="PageCategories_Item_Div">
            
                <asp:HyperLink ID="RightHyperLink" CssClass="Container_Left_LinkButton"  runat="server" 
                                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","Category"),Eval("Type"),Eval("StaticLink")) %>' 
                                            Text='<%# Eval("Name") %>'></asp:HyperLink>

                            <div class="Container_Left_Body_Row">
                                   <asp:HyperLink ID="HyperLink1" runat="server" 
                                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","Category"),Eval("Type"),Eval("StaticLink")) %>'>
                                            <asp:Image ID="ThumbnailImage" ImageUrl='<%#String.Format("{0}",Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail"))) %>' CssClass="Container_Left_Body_Thumbnail" runat="server" />
                                        </asp:HyperLink>
                              
                                <asp:Label ID="DescriptionLabel" Text='<%# Pages_BLL.FilterDescriptionText(Eval("Description"),100)%>' CssClass="Container_Left_Body_Description" runat="server" ></asp:Label>
                            </div>
            </div>

            </ItemTemplate>
</asp:DataList>
