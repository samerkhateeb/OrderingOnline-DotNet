<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Trackers.ascx.cs" Inherits="Admin.Admin.Controls.Trackers.Trackers" %>

<asp:GridView ID="ManagerGridView" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="Tracker_ID">
    <Columns>
        <asp:BoundField DataField="Tracker_UserID" HeaderText="UserID"></asp:BoundField>
        <asp:BoundField DataField="Tracker_URL" HeaderText="URL"></asp:BoundField>
        <asp:TemplateField HeaderText="Process">
            <EditItemTemplate>
                <%--<asp:TextBox ID="TextBox1" runat="server" Text='<%# getProcess(Eval("Tracker_Process")) %>'></asp:TextBox>--%>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Tracker_Process") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Tracker_Date" HeaderText="Date"></asp:BoundField>
        <asp:BoundField DataField="Tracker_AffectedID" HeaderText="AffectedID">
        </asp:BoundField>
    </Columns>
</asp:GridView>


