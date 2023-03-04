<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Careers_Details.ascx.cs" Inherits="Admin.Admin.Controls.Careers.Careers_Details" %>



<div class="Div_Row">
    
    <asp:Label ID="Label2" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
      <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
   
</div>

    <div class="Div_Row">
   <asp:Label ID="Label3" runat="server" Text="Email:" 
            AssociatedControlID="EmailTextBox"></asp:Label>
       <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    </div>

 

<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Phone:" 
            AssociatedControlID="PhoneTextBox"></asp:Label>
    <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
    </div>

  
    <div class="Div_Row">
 <asp:Label ID="Label4" runat="server" Text="Specialization:" 
            AssociatedControlID="SpecializationTextBox"></asp:Label>
    <asp:TextBox ID="SpecializationTextBox" runat="server"></asp:TextBox>
    </div>

   
    <div class="Div_Row">
   <asp:Label ID="Label5" runat="server" Text="Experience Years:" 
            AssociatedControlID="ExperienceYearsTextBox"></asp:Label>
   <asp:TextBox ID="ExperienceYearsTextBox" runat="server"></asp:TextBox>
    </div>

   
    <div class="Div_Row">
  <asp:Label ID="Label8" runat="server" Text="PMP Holder Status:" 
            AssociatedControlID="PMPHolderStatusTextBox"></asp:Label>
   <asp:TextBox ID="PMPHolderStatusTextBox" runat="server"></asp:TextBox>
   </div>

  
    <div class="Div_Row">
  <asp:Label ID="Label10" runat="server" Text="CV:" 
            AssociatedControlID="CVTextBox"></asp:Label>
   <asp:TextBox ID="CVTextBox" runat="server"></asp:TextBox>
   </div>

   
    <div class="Div_Row">
       <asp:Label ID="Label6" runat="server" Text="Country:" 
            AssociatedControlID="CountryTextBox"></asp:Label>
    <asp:TextBox ID="CountryTextBox" runat="server"></asp:TextBox>
   </div>

    

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
