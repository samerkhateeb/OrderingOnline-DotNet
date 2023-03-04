<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Banners.ascx.cs" Inherits="ControlPanel_CP_Controls_UC_BannersManager" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Banner" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Banner_ID" 
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Banner_Name" HeaderText="Name" />
        <asp:CheckBoxField DataField="Banner_SubPage" HeaderText="SubPage" />
        <asp:CheckBoxField DataField="Banner_Top" HeaderText="Top" />
        <asp:CheckBoxField DataField="Banner_Status" HeaderText="Status" 
            SortExpression="Banner_Status" />
        <asp:BoundField DataField="Banner_Sorting" HeaderText="Sorting" 
            SortExpression="Banner_Sorting" />
        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True" ButtonType="Image" 
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png"></asp:CommandField>
        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Banner_ID"), Request.QueryString["controlid"]) %>' 
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
        <asp:CheckBoxField />
        
    </Columns>
</asp:GridView>