<%@ Control Language="C#" AutoEventWireup="True" Inherits="Portals_Controls_UC_MidContainer" Codebehind="Mid.ascx.cs" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<div class="Container_Mid_Div">
<asp:GridView ID="MidGridView" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ParentID" ShowHeader="False" ShowFooter="false" Width="100%" >
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
            <div class="Container_Mid_Header_Div">
                   <asp:HyperLink ID="HeaderHyperLink" CssClass="Container_Mid_Header_LinkButton FloatRight" runat="server">
                    </asp:HyperLink>
            </div>  
            <div class="Container_Mid_Body MarginBottom5">
                <asp:GridView ID="MidDetailsGridView" AutoGenerateColumns="False" runat="server" DataKeyNames="ID" Width="100%" ShowFooter="False" ShowHeader="false">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                            </HeaderTemplate>
                            <ItemTemplate>
                            
                            <div class="Container_Mid_Body_Row">
                                
                                    <asp:HyperLink ID="HyperLink" CssClass="Container_Mid_Body_LinkButton FloatRight"  NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' runat="server">
                                        <img id="Img1" src='<%#  Global_BLL.FilterImagePathToThumbnail(Eval("Thumbnail")) %>'  class="Container_Mid_Body_Thumbnail FloatLeft" runat="server" />
                                    </asp:HyperLink>
                                    
                                    <asp:HyperLink ID="MidHyperLink" Text='<%# Eval("Name") %>' CssClass="Container_Mid_Body_LinkButton"  NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' runat="server"></asp:HyperLink>
                                    
                                    <asp:Label ID="DescriptionLabel" Text='<%# Pages_BLL.FilterDescriptionText(Eval("Description"),500)%>' CssClass="Container_Mid_Body_LabelDescription" runat="server" ></asp:Label>
                                </div>
                                <br class="ClearBoth" />
                                <hr />
                            
                            
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                
                </div>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</div>