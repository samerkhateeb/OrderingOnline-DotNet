<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Admin.Admin.Controls.SubPages.WebUserControl1" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New SubPage" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="SP_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_RowPaging" PageSize="30" 
    ondatabound="ManagerGridView_DataBound" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        
        <asp:TemplateField HeaderText="Parent">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("CAT_NameEng") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CAT_NameEng") %>'></asp:TextBox>
            </EditItemTemplate>
            <ControlStyle Width="100px" />
        </asp:TemplateField>
        <asp:BoundField DataField="SP_NameEng" HeaderText="NameEng" >
        <ControlStyle Width="150px" />
        </asp:BoundField>
        <%--<asp:TemplateField HeaderText="Type">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Type_Name") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:DropDownList ID="TypesDropDownList" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
        </asp:TemplateField>--%>
        <asp:BoundField DataField="SP_Sorting" HeaderText="Sorting" >
        <ControlStyle Width="50px" />
        </asp:BoundField>
        <asp:BoundField DataField="SP_Thumbnail" HeaderText="Thumbnail" >
        <ControlStyle Width="140px" />
        </asp:BoundField>
        <asp:CheckBoxField DataField="SP_Status" HeaderText="Status" />
        
        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>

        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# URL.Link_Edit(Eval("SP_ID"), Eval("CAT_ID")) %>'></asp:HyperLink>
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