<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contact.ascx.cs" Inherits="ControlPanel_CP_Controls_UC_ContactManager" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Contact" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Contact_ID" 
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Contact_Name" HeaderText="Name" />
        <asp:BoundField DataField="Contact_Email" HeaderText="Email" />
        <asp:BoundField DataField="Contact_Sorting" HeaderText="Sorting" />
        <asp:CheckBoxField DataField="Contact_Status" HeaderText="Status" />



        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>



        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Contact_ID"), Request.QueryString["controlid"]) %>' 
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