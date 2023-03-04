<%@ Control Language="C#" AutoEventWireup="True" Inherits="Portals_Controls_UC_SPGroups" Codebehind="Groups.ascx.cs" %>
<%@ Import Namespace="KFGCMS.BLL" %>
 <div class="Container_Right_Body">
    <asp:GridView ID="GroupDetailsGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" GridLines="None" >
        <Columns>
            <asp:TemplateField>
               
                <HeaderTemplate>
                    <div class="Container_Right_Header_Div FloatRight">
                        <asp:Label ID="HeaderLabel" CssClass="Container_Mid_Header_Label" runat="server">
                        </asp:Label>                                
                    </div>
                
                </HeaderTemplate>
                
                <ItemTemplate>
                <div class="Container_Right_Body_Row">
                    <asp:HyperLink ID="LeftHyperLink" CssClass="Container_Right_Body_LinkButton" SkinID="NoSkin" runat="server" 
                            NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                            Text='<%# Eval("Name") %>'></asp:HyperLink>
                </div>    
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
