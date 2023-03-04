<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pages.ascx.cs" Inherits="Admin.Admin.Controls.Pages.Pages" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>

<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Page" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Page_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    ondatabound="ManagerGridView_DataBound" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Page_NameEng" HeaderText="NameEng" />
        <asp:TemplateField HeaderText="Type">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Type_Name") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:DropDownList ID="TypesDropDownList" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CheckBoxField DataField="Page_Status" HeaderText="Status" />
        <asp:TemplateField HeaderText="Sorting">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Page_Sorting") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Height="25px" 
                    Text='<%# Bind("Page_Sorting") %>' Width="95px"></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>


        <asp:TemplateField HeaderText="Catergories">
            <ItemTemplate>
                <asp:HyperLink ID="PageHyperLink" runat="server" 
                    NavigateUrl='<%# URL.Link_Childs(Eval("Page_ID")) %>' 
                    CssClass="GV_SubPageBtn"></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>

        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Page_ID"), Request.QueryString["controlid"]) %>' 
                    Text=""></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField ShowHeader="False" HeaderText="Delete">
            <ItemTemplate>
                 <asp:ImageButton ID="ImageButtonDelete" runat="server" CommandName="Delete" 
                                    ImageUrl="~/Admin/images/delete.gif" 
                                    OnClientClick="return confirm('Are you sure you want to delete this Item?')" />
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<p>
    &nbsp;</p>
