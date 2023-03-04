<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTXNDetails.ascx.cs" Inherits="Admin.Admin.Controls.SalesTXNDetails.SalesTXNDetails" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>


<%--<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Sales TXNLine" />--%>
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="SalesTXNDetail_ID"  
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>
        <asp:BoundField DataField="SalesTXNDetail_Name" HeaderText="Name" />
        <asp:BoundField DataField="SalesTXNDetail_SalesTXNID" HeaderText="SalesTXNID" />
        <asp:Boundfield DataField="SalesTXNDetail_Price" HeaderText="Price" />
        <asp:Boundfield DataField="SalesTXNDetail_QTY" HeaderText="Quantity" />



        <%--<asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>--%>



        <asp:TemplateField HeaderText="Edit">

            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# URL.Link_Edit(Eval("SalesTXNDetail_ID"), Eval("SalesTXNDetail_SalesTXNID")) %>'
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