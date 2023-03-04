<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_Discussions.ascx.cs" Inherits="Portals_Controls_UC_Discussions" %>
<%@ Import Namespace="KFGCMS.BLL" %>

    <div class="Container_Right_Header_Div">
                            <asp:Label ID="HeaderLabel" CssClass="Container_Mid_Header_Label" runat="server"></asp:Label>
    </div>
<div class="Container_Right_Body">
        <asp:GridView ID="DiscussionsGridView" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="ID" GridLines="None" >
            <Columns>
                <asp:TemplateField>
                   
                    <HeaderTemplate>
                       
                    </HeaderTemplate>
                    
                    <ItemTemplate>
                        <div class="Container_Right_Body_Row FloatRight">
                            <asp:Label ID="TitleLabel" runat="server" CssClass="Container_Right_Body_Label" Text='<%# Eval("Title") %>'></asp:Label><br />
                           <%-- <asp:Label ID="DescriptionLabel" runat="server"  CssClass="Container_Mid_Body_LabelDescription" Text='<%# Eval("Description") %>'></asp:Label>
                            <br /><br />--%>
                            <asp:HyperLink ID="LeftHyperLink" runat="server" CssClass="Discussion_LinkButton MarginCenter" 
                                NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' >
                            </asp:HyperLink>
                                <br />
                        </div>
                    </ItemTemplate>
                    
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</div>