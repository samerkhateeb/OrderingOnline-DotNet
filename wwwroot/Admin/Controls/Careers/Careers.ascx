<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Careers.ascx.cs" Inherits="ControlPanel_CP_Controls_UC_CareersManager" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Career" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="Career_ID"
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="Career_Name" HeaderText="Name" />
       <%-- <asp:BoundField DataField="Career_Email" HeaderText="Email" />--%>
        <asp:BoundField DataField="Career_Phone" HeaderText="Phone" />
        <asp:BoundField DataField="Career_Specialization" HeaderText="Specialization" />
        <%--<asp:BoundField DataField="Career_ExperienceYears" HeaderText="ExperienceYears" />
        <asp:BoundField DataField="Career_PMPHolderStatus" HeaderText="PMPHolderStatus" />
        <asp:BoundField DataField="Career_CV" HeaderText="CV" />--%>
       <%--<asp:BoundField DataField="Career_Country" HeaderText="Country" />
 --%>
        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True" CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png"  ButtonType="Image"></asp:CommandField>

        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Career_ID"), Request.QueryString["controlid"]) %>' 
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