<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Drinks.ascx.cs" Inherits="Admin.Admin.Controls.Drinks.Drinks" %>

<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Drink" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Drink_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Drink_GroupID" HeaderText="GroupID" />
        <asp:BoundField DataField="Drink_NameEng" HeaderText="Name" />
        <asp:CheckBoxField DataField="Drink_Status" HeaderText="Status" />
        <asp:BoundField DataField="Drink_Sorting" 
            HeaderText="Sorting" />
           <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image">
        </asp:CommandField>
           <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Drink_ID"), Request.QueryString["controlid"]) %>' 
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