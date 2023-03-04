<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Signup.ascx.cs" Inherits="Admin.Admin.Controls.Signup.Signup" %>

<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New Signup" />

<asp:GridView ID="ManagerGridView" runat="server" AutoGenerateColumns="False" 
    onrowdeleting="ManagerGridView_RowDeleting">
    <Columns>
        <asp:BoundField DataField="Signup_Name" HeaderText="Name" />
        <asp:BoundField DataField="Signup_Email" HeaderText="Email" />
        <asp:BoundField DataField="Signup_RestaurentName" HeaderText="RestaurentName" />
        <asp:BoundField DataField="Signup_PostCode" HeaderText="PostCode" />
        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("Signup_ID"), Request.QueryString["controlid"]) %>' 
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



