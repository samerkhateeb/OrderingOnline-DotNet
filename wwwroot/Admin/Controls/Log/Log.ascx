<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Log.ascx.cs" Inherits="Admin.Admin.Controls.Log.Log" %>

<asp:GridView ID="ManagerGrid" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:TemplateField HeaderText="Name">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl='<%# String.Format("/Log/{0}", Eval("Name")) %>' Target="_blank" 
                    Text='<%# Eval("Name") %>'></asp:HyperLink>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemStyle Width="140px" />
        </asp:TemplateField>
        <asp:BoundField DataField="Size" HeaderText="Size" >
        <ItemStyle Width="70px" />
        </asp:BoundField>
        <asp:BoundField DataField="Date" HeaderText="Date" />
    </Columns>
</asp:GridView>