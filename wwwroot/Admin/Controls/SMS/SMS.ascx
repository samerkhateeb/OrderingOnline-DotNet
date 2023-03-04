﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SMS.ascx.cs" Inherits="Admin.Admin.Controls.SMS.SMS" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New SMS" />
    
<asp:GridView ID="ManagerGridView" runat="server" 
    AutoGenerateColumns="False" DataKeyNames="SMS_ID"  
    onrowdeleting="ManagerGridView_RowDeleting" AllowPaging="True" 
    onpageindexchanging="ManagerGridView_PageIndexChanging" PageSize="30" 
    onrowcancelingedit="ManagerGridView_RowCancelingEdit" 
    onrowediting="ManagerGridView_RowEditing" 
    onrowupdating="ManagerGridView_RowUpdating" >
    <Columns>
        <asp:BoundField DataField="SMS_Name" HeaderText="Name" />
        <asp:BoundField DataField="SMS_Mobile" HeaderText="Mobile" />
        <asp:CheckBoxField DataField="SMS_Status" HeaderText="Status" />
        <asp:BoundField DataField="SMS_Sorting" HeaderText="Sorting" />



        <asp:CommandField HeaderText="Q Edit" ShowEditButton="True"
            CancelImageUrl="/Assets/Files/Admin/qCancel.png" 
            EditImageUrl="/Assets/Files/Admin/qEdit.png" 
            UpdateImageUrl="/Assets/Files/Admin/qUpdate.png" ButtonType="Image"></asp:CommandField>



        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("SMS_ID"), Request.QueryString["controlid"]) %>' 
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