<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VotingQuestions.ascx.cs" Inherits="Admin.Admin.Controls.VotingQuestions.VotingQuestions" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>

<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New VQuestion" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="VQuestion_ID" 
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating" >
    <Columns>
        <asp:BoundField DataField="VQuestion_NameEng" HeaderText="NameEng" />
        <asp:CheckBoxField DataField="VQuestion_Status" HeaderText="Status" />
        <asp:BoundField DataField="VQuestion_Sorting" HeaderText="Sorting" />



        <asp:TemplateField HeaderText="VotingAnswer">
            <ItemTemplate>
                <asp:HyperLink ID="VAnswerHyperLink" runat="server" CssClass="GV_SubPageBtn"
                    NavigateUrl='<%# URL.Link_Childs(Eval("VQuestion_ID")) %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>



        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>



        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("VQuestion_ID"), Request.QueryString["controlid"]) %>' 
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
