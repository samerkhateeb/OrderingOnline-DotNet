<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Category.ascx.cs" Inherits="Category.Category" %>
<%@ Import Namespace="KFGCMS.BLL" %>

<div class="Category_Div"> 

    <asp:GridView ID="CategoryGridView" runat="server" ShowHeader="false"  GridLines="None" 
        AutoGenerateColumns="False" Width="100%" 
        >
                <EditRowStyle BorderWidth="0px" />
                <RowStyle BorderWidth="0px" />
                <SelectedRowStyle BorderWidth="0px" />
                <AlternatingRowStyle BorderWidth="0px" />
                <Columns>
                    <asp:TemplateField>
                            <ItemTemplate>

                            <asp:Panel runat="server" Visible="false" ID="Skin3Panel">
                            <div class="Category_Skin3_Row">
                            <div class="Category_DivRight">
                                <%--<asp:HyperLink ID="ImageHyperLink"  runat="server"> </asp:HyperLink>--%>
                                <a href="javascript:void(0);" onclick='<%#String.Format("javascript:AddOrder({0});return false;",Eval("ID")) %>'>
                                    <asp:Image ID="Skin3Image" CssClass="Category_Skin3_Thumbnail" runat="server"/>
                                </a>
                                    <a href="javascript:void(0);" onclick='<%#String.Format("javascript:AddOrder({0});return false;",Eval("ID")) %>' class="Category_Skin3_Item_OrderNow"></a>                            
                            </div>

                            <div class="Category_DivLeft">
                                <%--<asp:HyperLink ID="HeaderHyperLink" runat="server" Text='<%#Eval("Name") %>' NavigateUrl=''  CssClass="Category_Skin3_Row_LinkButton"></asp:HyperLink> 
                                href='<%# Pages_BLL.GenerateUrl(Eval("ID"),"SubPage",Eval("Type"),Eval("StaticLink")) %>'--%>
                                <asp:Image ID="NewImage" ImageUrl="~/Assets/Images/new.gif" Visible="false" CssClass="Category_Skin3_NewImage" runat="server" />
                                <a id='<%# String.Format("ItemName{0}", Eval("ID")) %>' href="void(0);" onclick='<%#String.Format("javascript:AddOrder({0});return false;",Eval("ID")) %>' class='<%# String.IsNullOrEmpty(Eval("NewIconStatus").ToString())? "Category_Skin3_Row_LinkButton":"Category_Skin3_Row_LinkButton_WithNewImage" %>'><%#Eval("Name") %></a>
                                <asp:Label ID="DescriptionLabel" runat="server" CssClass="Category_Skin3_Row_Description"></asp:Label>

                                <asp:DataList ID="Skin3DataList" runat="server" RepeatColumns="3" DataKeyField="SP_Type_Code" HorizontalAlign="left" 
                                            RepeatLayout="Flow" RepeatDirection="Horizontal" Width="100%" >
                                    <AlternatingItemStyle VerticalAlign="Top" />
                                    <ItemStyle VerticalAlign="Top" />
                                    <ItemTemplate>
                                    <div class="Category_Skin3_Item_Div">
                                        <div id='<%# String.Format("ItemTypeName{0}{1}", Eval("RowID"), Eval("ItemSorting") ) %>' class="Category_Skin3_Item_Title"><%#Eval("CAT_Type_Name")%></div>
                                        <div class="Category_Skin3_Item_Price">KD <%#Eval("SP_Type_Price")%></div>
                                        <div id='<%# String.Format("ItemPrice{0}{1}", Eval("RowID"), Eval("ItemSorting") ) %>' class="Hide"><%#Eval("SP_Type_Price")%></div>
                                        <asp:Label ID="Label1" CssClass="Category_Skin3_Item_Quantity_Label" runat="server" Text="Quantity: "></asp:Label>
                                        <select id='<%# String.Format("ItemQuantity{0}{1}", Eval("RowID"), Eval("ItemSorting") ) %>'>
                                            <option value="0">0</option>
                                            <option value="1">1</option>
                                            <option value="2">2</option>
                                            <option value="3">3</option>
                                            <option value="4">4</option>
                                            <option value="5">5</option>
                                            <option value="6">6</option>
                                            <option value="7">7</option>
                                            <option value="8">8</option>
                                            <option value="9">9</option>
                                            <option value="10">10</option>
                                        </select>
                                        <%--<asp:DropDownList ID="QuantityDropDownList" CssClass="Category_Skin3_Item_Quantity_DropDownList" runat="server">
                                        <asp:ListItem Text="0" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                        <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                        </asp:DropDownList>--%>
                                        <a href="javascript:;" class="Category_Skin3_Item_Modifiers"></a>                            

                                        <input id='<%# String.Format("IDHidden{0}", Eval("RowID")) %>' value='<%# String.Format("{0}", Eval("ID")) %>' type="hidden" />
                                        <input id='<%# String.Format("RowIDHidden{0}", Eval("ID")) %>' value='<%# String.Format("{0}", Eval("RowID")) %>' type="hidden" />
                                        <%--<input ='<%# String.Format("ItemSortingHidden{0}", Eval("RowID")) %>' value='<%# String.Format("{0}", Eval("ItemSorting")) %>' type="hidden" />--%>

                                        <%--<asp:HiddenField ID="RowIDHiddenField" Value='<%# Eval("RowID") %>' runat="server" />--%>
                                    </div>
                                    </ItemTemplate>
                            </asp:DataList>

                            </div>
                            </div>
                        </asp:Panel>

                        </ItemTemplate>  
                    </asp:TemplateField>
                </Columns>
                
        </asp:GridView>
</div>


