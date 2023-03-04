<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Categories.ascx.cs" Inherits="Admin.Admin.Controls.Categories.Categories" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>

<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Category" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="CAT_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating" 
    ondatabound="ManagerGridView_DataBound">
    <Columns>
        <asp:BoundField DataField="Page_NameEng" HeaderText="Parent">
        <ControlStyle Width="100px" />
        </asp:BoundField>
        <asp:BoundField DataField="CAT_NameEng" HeaderText="NameEng" >
        <ControlStyle Width="150px" />
        </asp:BoundField>
        <asp:TemplateField HeaderText="Type">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Type_Name") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:DropDownList ID="TypesDropDownList" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
            <ControlStyle Width="100px" />
        </asp:TemplateField>
        <asp:BoundField DataField="CAT_Sorting" HeaderText="Sorting" >
        <ControlStyle Width="60px" />
        </asp:BoundField>
        <asp:CheckBoxField DataField="CAT_Status" HeaderText="Status" />

        <asp:TemplateField HeaderText="Subpages">
            <ItemTemplate>
                <asp:HyperLink ID="SubpageHyperLink" runat="server" CssClass="GV_SubPageBtn" 
                               NavigateUrl='<%# URL.Link_Childs(Eval("CAT_ID")) %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:CommandField ButtonType="Image" HeaderText="Q Edit"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" 
            ShowEditButton="True" />

        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" NavigateUrl='<%# URL.Link_Edit(Eval("CAT_ID"), Eval("Page_ID")) %>'></asp:HyperLink>
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