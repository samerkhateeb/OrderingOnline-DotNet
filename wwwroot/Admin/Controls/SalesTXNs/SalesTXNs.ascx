<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesTXNs.ascx.cs" Inherits="Admin.Admin.Controls.SalesTXNs.SalesTXNs" %>
<%@ Import Namespace="KFGCMS.Admin.BLL" %>



<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="SalesTXN_ID"  
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating">
    <Columns>

        <%--<asp:BoundField DataField="SalesTXN_Date" HeaderText="Date" />--%>



        <asp:BoundField DataField="SalesTXN_ID" HeaderText="ID" />
        <asp:BoundField DataField="SalesTXN_StaffID" HeaderText="Staff ID" />
        <asp:BoundField DataField="Customer_Name" HeaderText="Name" />
        <asp:BoundField DataField="SalesTXN_VoucherValue" HeaderText="Value" />
        <asp:TemplateField HeaderText="Type">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    
                    Text='<%# Eval("SalesTXN_Type").ToString() == "55"? "Pick Up":"Home Delivery" %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" 
                    Text='<%# Bind("SalesTXN_Type") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>


        <asp:TemplateField HeaderText="Date and Time">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Convert.ToDateTime(Eval("SalesTXN_Date")).ToString("dd MMMM yyyy, H:m") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("SalesTXN_Date") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>


        <asp:BoundField DataField="SalesTXN_COTMessage" HeaderText="COT Message" />

          <asp:TemplateField HeaderText="Details">
            <ItemTemplate>
                <asp:HyperLink ID="SubpageHyperLink" runat="server" CssClass="GV_SubPageBtn" 
                               NavigateUrl='<%# URL.Link_Childs(Eval("SalesTXN_ID")) %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>

       <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# URL.Link_Edit(Eval("SalesTXN_ID"), Eval("SalesTXN_CustomerID")) %>' 
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
