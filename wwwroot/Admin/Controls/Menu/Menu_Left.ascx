<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu_Left.ascx.cs" Inherits="Admin.Admin.Controls.Menu.Menu_Left" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>


<div class="Menu_Div">

      <%--  <a href="Default.aspx" class="Menu_LinkButton" target="_self" >Home Page</a>
        <img src="images/Menu_Line.png" />
        <a href="Default.aspx" class="Menu_LinkButton" target="_self" >Catergory</a>
        <img src="images/Menu_Line.png" />
        <a href="Default.aspx" class="Menu_LinkButton" target="_self" >Sub Page</a>
        <img src="images/Menu_Line.png" />
--%>
        <asp:DataList ID="SettingsDataList" runat="server" Width="100%" RepeatLayout="Flow" DataKeyField="Control_ID" RepeatColumns="100" >
                <ItemTemplate>
                        <a href='<%#  URL.Home_GetLink(Eval("Control_ID"), Eval("Control_ChildID")) %>' class="Menu_LinkButton"><%# Eval("Control_Name") %></a>
                </ItemTemplate>
            </asp:DataList>

               <%-- <asp:GridView ID="SettingsMenuGridView" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="CP_Page_ID" GridLines="None" 
                    onrowcommand="SettingsMenuGridView_RowCommand" SkinID="NoSkin">
                    <Columns>
                        <asp:TemplateField>
                            <EditItemTemplate>
                                <asp:TextBox ID="PageTextBox" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <HeaderTemplate>
                                <asp:Label ID="Label3" runat="server" Text="Settengs Pages" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="PageLinkButton" runat="server" CssClass="Menu_LinkButton" SkinID="NoSkin" Text='<%# Eval("CP_Page_Name") %>' 
                                    CommandName='<%# Eval("CP_Page_StaticLink") %>' CausesValidation="False"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>--%>
                                    
            <%--     <asp:GridView ID="PagesMenuGridView" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="page_id" GridLines="None" 
                    onrowcommand="MenuGridView_RowCommand" SkinID="NoSkin">
                        <Columns>
                        <asp:TemplateField>
                            <EditItemTemplate>
                                <asp:TextBox ID="PageTextBox" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <HeaderTemplate>
                                <asp:Label ID="Label3" runat="server" Text="Portal Pages" ></asp:Label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="PageLinkButton" runat="server" SkinID="NoSkin" CssClass="Menu_LinkButton" Text='<%# Eval("Page_TitleEng") %>' 
                                    CommandName='<%# Eval("Page_TypeID") %>' CausesValidation="False"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>--%>
            </div>