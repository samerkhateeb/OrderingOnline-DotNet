<%@ Control Language="C#" AutoEventWireup="True" Inherits="Left" Codebehind="Left.ascx.cs" %>
<%@ Import Namespace="KFGCMS.BLL" %>

 <div class="Container_Left_Div">
<asp:GridView ID="LeftParentGridView" runat="server" Width="100%" ShowHeader="False" AutoGenerateColumns="False" BorderWidth="0" DataKeyNames="ParentID">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>

            <div runat="server" id="ChildGridHeader">
                    <asp:HyperLink ID="HeaderHyperLink" CssClass="Container_Left_Header_LinkButton" runat="server">
                    </asp:HyperLink>
            </div>
            
            <div class="Container_Left_Body">
            
                <asp:GridView ID="LeftStaticGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" Width="100%" ShowFooter="true" ShowHeader="False">
                   
                    <Columns>
                        <asp:TemplateField>
                            
                            <ItemTemplate>
                                <div class="Container_Left_Body_Row">
                                    <asp:HyperLink ID="RightHyperLink" CssClass="Container_Left_Body_LinkButton" runat="server" 
                                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                            Text='<%# Eval("Name") %>'></asp:HyperLink>
                                </div>
                               
                            </ItemTemplate>
                                <FooterTemplate>
                                    <div class="Container_Left_More_Div">
                                        <asp:HyperLink ID="MoreHyperLink" CssClass="Container_Left_More_LinkButton FloatRight" runat="server"  >
                                        </asp:HyperLink>
                                    </div>
                                </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                 
                
                 <asp:GridView ID="LeftImageGridView" runat="server" AutoGenerateColumns="False"  CellPadding="0" CellSpacing="0" BorderWidth="0"
                    DataKeyNames="ID" Width="100%" GridLines="None" ShowFooter="false" ShowHeader="false">
                     
                    <Columns>
                        <asp:TemplateField>            
                            <ItemTemplate>
                              <asp:HyperLink ID="RightHyperLink" CssClass="Container_Left_LinkButton"  runat="server" 
                                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                            Text='<%# Eval("Name") %>'></asp:HyperLink>

                            <div class="Container_Left_Body_Row">
                                   <asp:HyperLink ID="HyperLink1" runat="server" 
                                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>'>
                                            <asp:Image ID="ThumbnailImage" ImageUrl='<%#String.Format("{0}",Global_BLL.ResolveImagePath(Eval("Thumbnail"))) %>' CssClass="Container_Left_Body_Thumbnail" runat="server" />
                                        </asp:HyperLink>
                              
                                <asp:Label ID="DescriptionLabel" Text='<%# Pages_BLL.FilterDescriptionText(Eval("Description"),100)%>' CssClass="Container_Left_Body_Description" runat="server" ></asp:Label>
                            </div>
                            
                            </ItemTemplate>
                          <%--  <FooterTemplate>
                                    <div class="Container_Left_More_Div">
                                        <asp:HyperLink ID="MoreHyperLink" CssClass="Container_Left_More_LinkButton FloatRight" runat="server"  >
                                        </asp:HyperLink>
                                    </div>
                                </FooterTemplate>--%>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                

                </div>
                
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</div>
<asp:HiddenField ID="CurrentTypeHiddenField" runat="server" />
