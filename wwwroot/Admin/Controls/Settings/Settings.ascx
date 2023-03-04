<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="Admin.Admin.Controls.Settings.Settings" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Setting" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Setting_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Setting_HotNewsTitle" HeaderText="HotNews Title" />
        <%--<asp:BoundField DataField="Setting_HotNewsCount" HeaderText="HotNewsCount" />
        <asp:BoundField DataField="Setting_LastNewsTitle" HeaderText="LastNewsTitle" />
        <asp:BoundField DataField="Setting_LastNewsCount" HeaderText="LastNewsCount" />
        <asp:CheckBoxField DataField="Setting_MostStatus" HeaderText="MostStatus" />
        <asp:BoundField DataField="Setting_MostEmailCount" HeaderText="MostEmailCount" />
        <asp:CheckBoxField DataField="Setting_MostEmailStatus" HeaderText="MostEmailStatus" />
        <asp:BoundField DataField="Setting_MostCommentCount" HeaderText="MostCommentCount" />
        <asp:CheckBoxField DataField="Setting_MostCommentStatus" HeaderText="MostCommentStatus" />
        <asp:BoundField DataField="Setting_MostVISITCount" HeaderText="MostVISITCount" />
        <asp:CheckBoxField DataField="Setting_MostVisitStatus" HeaderText="MostVisitStatus" />
        <asp:BoundField DataField="Setting_DiscussionsTitle" HeaderText="DiscussionsTitle" />
        <asp:BoundField DataField="Setting_DiscussionsCount" HeaderText="DiscussionsCount" />
        <asp:CheckBoxField DataField="Setting_DiscussionsStatus" HeaderText="DiscussionsStatus" />--%>


        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>


        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Setting_ID"), Request.QueryString["controlid"]) %>' 
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