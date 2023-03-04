<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StaticControls.ascx.cs" Inherits="Admin.Admin.Controls.StaticControls.StaticControls" %>


<asp:Button ID="InsertButton" runat="server" onclick="InsertLinkButton_Click" 
    Text="New StaticControl" />

<asp:GridView ID="ManagerGridView" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="StaticControl_ID" onrowdeleting="ManagerGridView_RowDeleting">
    <Columns>
        <asp:BoundField DataField="StaticControl_ID" HeaderText="ID" />
        <asp:BoundField DataField="StaticControl_Name" HeaderText="Name" />
        <asp:BoundField DataField="StaticControl_ControlID" HeaderText="ControlID" />
        <asp:BoundField DataField="StaticControl_Date" HeaderText="Date" />
    

 <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="GV_EditBtn" 
                    NavigateUrl='<%# String.Format("/admin/default.aspx?id={0}&controlid={1}&status=edit", Eval("StaticControl_ID"), Request.QueryString["controlid"]) %>' 
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