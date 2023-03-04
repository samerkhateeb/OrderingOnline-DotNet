<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Objects_Details.ascx.cs" Inherits="Admin.Admin.Controls.Objects.Objects_Details" %>



    <div class="Div_Row">
    
        <asp:Label ID="Label3" runat="server" Text="Parent ID:" AssociatedControlID="ParentIDdropdownlist"></asp:Label>
        <asp:dropdownlist ID="ParentIDdropdownlist" runat="server">
        <asp:ListItem Value="0">No Parent</asp:ListItem>
        </asp:dropdownlist>
         
</div>

 <div class="Div_Row">
   <asp:Label ID="Label1" runat="server" Text="Levels:" AssociatedControlID="Levelsdropdownlist"></asp:Label>
    <asp:dropdownlist ID="Levelsdropdownlist" runat="server">
        <asp:ListItem>0</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
     </asp:dropdownlist>
     </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Type:" AssociatedControlID="Typedropdownlist"></asp:Label>
    <asp:dropdownlist ID="Typedropdownlist" runat="server"></asp:dropdownlist>
    </div>

  
<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
