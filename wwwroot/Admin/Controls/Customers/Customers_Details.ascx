<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customers_Details.ascx.cs" Inherits="Admin.Admin.Controls.Customers.Customers_Details1" %>


<div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="*" ForeColor="Red" ControlToValidate="NameTextBox" 
        SetFocusOnError="True"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Telephone:" 
            AssociatedControlID="TelephoneTextBox"></asp:Label>
    <asp:TextBox ID="TelephoneTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Address_GridID:" 
            AssociatedControlID="Address_GridIDTextBox"></asp:Label>
    <asp:TextBox ID="Address_GridIDTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Address_BlockID:" 
            AssociatedControlID="Address_AreaIDTextBox"></asp:Label>
    <asp:TextBox ID="Address_AreaIDTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="Address_Building:" 
            AssociatedControlID="Address_BuildingTextBox"></asp:Label>
    <asp:TextBox ID="Address_BuildingTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="Address_Street:" 
            AssociatedControlID="Address_StreetTextBox"></asp:Label>
    <asp:TextBox ID="Address_StreetTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="Address_Floor:" 
            AssociatedControlID="Address_FloorTextBox"></asp:Label>
    <asp:TextBox ID="Address_FloorTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="Address_Flat:" 
            AssociatedControlID="Address_FlatTextBox"></asp:Label>
    <asp:TextBox ID="Address_FlatTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label9" runat="server" Text="Address_Other:" 
            AssociatedControlID="Address_OtherTextBox"></asp:Label>
    <asp:TextBox ID="Address_OtherTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="Date:" 
            AssociatedControlID="DateTextBox"></asp:Label>
    <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
    </div>

     <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="Remarks:" 
            AssociatedControlID="RemarksTextBox"></asp:Label>
    <asp:TextBox ID="RemarksTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label12" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label13" runat="server" Text="Gender:" 
            AssociatedControlID="GenderTextBox"></asp:Label>
    <asp:TextBox ID="GenderTextBox" runat="server"></asp:TextBox>
    </div>


    <div class="Div_Row">
    <asp:Label ID="Label14" runat="server" Text="BirthDate:" 
            AssociatedControlID="BirthDateTextBox"></asp:Label>
    <asp:TextBox ID="BirthDateTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label15" runat="server" Text="Occupation:" 
            AssociatedControlID="OccupationTextBox"></asp:Label>
    <asp:TextBox ID="OccupationTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label16" runat="server" Text="Email:" 
            AssociatedControlID="EmailTextBox"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label17" runat="server" Text="Password:" 
            AssociatedControlID="PasswordTextBox"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label18" runat="server" Text="AuthCode:" 
            AssociatedControlID="AuthCodeTextBox"></asp:Label>
    <asp:TextBox ID="AuthCodeTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label19" runat="server" Text="RegistrationStatus:" 
            AssociatedControlID="RegistrationStatusTextBox"></asp:Label>
    <asp:TextBox ID="RegistrationStatusTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label20" runat="server" Text="COT Message:" 
            AssociatedControlID="COTMessageTextBox"></asp:Label>
    <asp:TextBox ID="COTMessageTextBox" runat="server"></asp:TextBox>
    </div>

   <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
