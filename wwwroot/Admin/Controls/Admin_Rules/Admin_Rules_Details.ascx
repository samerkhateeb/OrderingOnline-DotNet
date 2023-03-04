<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Admin_Rules_Details.ascx.cs" Inherits="Admin.Admin.Controls.Admin_Rules.Admin_Rules_Details" %>


<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Name:" 
        AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Description:" 
        AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label5" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True" />
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

   
    <div class="Div_Row">
      
        <asp:Label ID="Label7" runat="server" Text="UpdateStatus:" AssociatedControlID="UpdateStatusCheckBox"></asp:Label>
        <asp:CheckBox ID="UpdateStatusCheckBox" runat="server" />
        </div>

        <div class="Div_Row">
      
        <asp:Label ID="Label2" runat="server" Text="InsertStatus:" AssociatedControlID="InsertStatusCheckBox"></asp:Label>
        <asp:CheckBox ID="InsertStatusCheckBox" runat="server" />
        </div>

         <div class="Div_Row">
      
        <asp:Label ID="Label4" runat="server" Text="DeleteStatus:" AssociatedControlID="DeleteStatusCheckBox"></asp:Label>
        <asp:CheckBox ID="DeleteStatusCheckBox" runat="server" />
        </div>

         <div class="Div_Row">
      
        <asp:Label ID="Label8" runat="server" Text="ViewStatus:" AssociatedControlID="ViewStatusCheckBox"></asp:Label>
        <asp:CheckBox ID="ViewStatusCheckBox" runat="server" />
        </div>


        <div class="Div_Row">
              
            <asp:Label ID="Label9" runat="server" Text="ControlIDs:" AssociatedControlID="ControlsIDCheckBoxList"></asp:Label>
            <asp:CheckBoxList ID="ControlsIDCheckBoxList" runat="server">
            </asp:CheckBoxList>
            
        
        
        </div>


    <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
