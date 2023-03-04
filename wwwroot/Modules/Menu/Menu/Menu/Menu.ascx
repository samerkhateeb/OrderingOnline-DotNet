<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="Menu.Menu" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<script src="/Modules/Menu/Script/Menu.js" type="text/javascript"></script>

<asp:Label ID="RightMenuLabel" runat="server" ></asp:Label>

<asp:Panel ID="FooterPanel" Visible="false" runat="server">
        <asp:DataList ID="MenuFooter1DataList" runat="server" RepeatColumns="10" RepeatLayout="Flow" RepeatDirection="Horizontal"  ShowFooter="False" ShowHeader="False">
            <ItemTemplate>
            <asp:HyperLink  ID="MenuHyperLink" runat="server" Text ='<%# Eval("PARENT_Name") %>' 
                            NavigateUrl='<%# Pages_BLL.GenerateMenuUrl(Eval("ParentID"),"Page",Eval("Parent_Type"),Eval("Parent_StaticLink")) %>' 
                            CssClass="Menu_Footer_LinkButton"  
                    ToolTip='<%# Eval("Parent_Description") %>'></asp:HyperLink>
            <span class="Menu_Footer_Label">&nbsp;&nbsp;|&nbsp;&nbsp;</span>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>

<asp:Panel ID="TopPanel" Visible="false" runat="server">
        <%--<asp:Literal ID="TopLiteral" runat="server"></asp:Literal>--%>

          <asp:DataList ID="TopDataList" runat="server" RepeatColumns="10" RepeatLayout="Flow" CssClass="MarginCenter" RepeatDirection="Horizontal"  ShowFooter="False" ShowHeader="False">
            <ItemTemplate>
                <asp:HyperLink  ID="MenuHyperLink" runat="server" Text ='<%# Eval("PARENT_Name") %>' 
                                NavigateUrl='<%# Pages_BLL.GenerateMenuUrl(Eval("ParentID"),"Page",Eval("Parent_Type"),Eval("Parent_StaticLink")) %>' 
                                CssClass="Menu_Top_LinkButton"  
                                ToolTip='<%# Eval("Parent_Description") %>'></asp:HyperLink>
           </ItemTemplate>
        </asp:DataList>
    <asp:LinkButton ID="LogLinkButton" OnClick="LogLinkButton_Click" CssClass="Login_LinkButton2" runat="server">Logout</asp:LinkButton>
</asp:Panel>


<asp:Panel ID="HeaderPanel" runat="server">
    <div class="FloatRight PaddingRight15">
            <asp:GridView ID="MenuRightGridView" runat="server" 
                          AutoGenerateColumns="False" CellPadding="0" 
                          CellSpacing="0" BorderWidth="0" ShowHeader="true">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                        <div class="Container_Right_Header_Div">
                            <asp:Label  ID="MenuHeaderLabel" 
                                        runat="server" 
                                        CssClass="Container_Mid_Header_Label"
                                        Text="روابط أخرى">
                            </asp:Label>
                        </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                             <asp:HyperLink ID="MenuHyperLink" runat="server" 
                                            Text ='<%# Eval("PARENT_Name") %>' 
                                            NavigateUrl='<%# Pages_BLL.GenerateMenuUrl(Eval("ParentID"),"Page",Eval("Parent_Type"),Eval("Parent_StaticLink")) %>' 
                                            CssClass="Menu_Item"  ToolTip='<%# Eval("Parent_Description") %>'>
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>                
    </div>
</asp:Panel>


<asp:Panel ID="PageCategoriesPanel" Visible="false" runat="server">
  <asp:DataList ID="PageCategoriesDataList" DataKeyField="ID" runat="server" RepeatColumns="4" RepeatLayout="Flow" RepeatDirection="Horizontal"  ShowFooter="False" ShowHeader="False">
            <ItemTemplate>
                <div id="MenuTop">
                    <asp:HyperLink ID="MenuHyperLink" runat="server"  NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),"Category",Eval("Type"),Eval("StaticLink")) %>' 
                    class="Menu_PageCateogires_LinkButton"><%# Eval("Name") %></asp:HyperLink>


                   <%-- <a id='MenuHyperLink' runat="server" title='<%# Eval("Description") %>'  href='<%# Pages_BLL.GenerateUrl(Eval("ID"),"Category",Eval("Type"),Eval("StaticLink")) %>' 
                    class="Menu_PageCateogires_LinkButton"  ><%# Eval("Name") %></a>--%>
              </div>
           </ItemTemplate>
        </asp:DataList>
</asp:Panel>

<asp:HiddenField ID="CurrentMenuTypeHiddenField" runat="server" />
