<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridsLocations_Details.ascx.cs" Inherits="Admin.Admin.Controls.GridsLocations.GridsLocations_Details" %>



<div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="Grid Name:"></asp:Label>
    <asp:TextBox ID="GridNameTextBox" runat="server"></asp:TextBox>
    </div>


<div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Grid Code:" 
            AssociatedControlID="Grid_IDTextBox"></asp:Label>
    <asp:TextBox ID="Grid_IDTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="Grid_IDTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
   </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Location ID:" 
        AssociatedControlID="Location_IDDropDownList"></asp:Label>
    <asp:DropDownList ID="Location_IDDropDownList" runat="server"></asp:DropDownList>
    </div>


     <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="Delivery Time:" 
        AssociatedControlID="Delivery_TimeTextBox"></asp:Label>
    <asp:TextBox ID="Delivery_TimeTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Delivery Amount:" 
        AssociatedControlID="Delivery_AmountTextBox"></asp:Label>
    <asp:TextBox ID="Delivery_AmountTextBox" runat="server"></asp:TextBox>
    </div>


     <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="Delivery Charge:" 
        AssociatedControlID="Delivery_ChargeTextBox"></asp:Label>
    <asp:TextBox ID="Delivery_ChargeTextBox" runat="server"></asp:TextBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Grid Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True" />
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="Grid Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label4" runat="server" Text="Grid Date:" AssociatedControlID="DateTextBox"></asp:Label>
    <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
    </div>


<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
