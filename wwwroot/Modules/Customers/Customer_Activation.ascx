<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customer_Activation.ascx.cs" Inherits="Customer.Customer_Activation" %>
<asp:Label ID="ResultLabel" Visible="false" runat="server" ></asp:Label>
<div class="Customer_Registration_Title">Activate Your Registration</div>
<asp:Label ID="WelcomeLabel" runat="server" Visible="false" CssClass="Customer_Registration_Title4"></asp:Label>
<br class="ClearBoth" />
<div class="Customer_Activation_Title">Your Authorization Code has been sent to you by SMS and registered email</div>


<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" CssClass="Label" Text="Phone Number" AssociatedControlID="PhoneTextBox"></asp:Label>
    <asp:Label ID="Label17" runat="server" Text="+ 965 - " CssClass="Label2" AssociatedControlID="PhoneTextBox"></asp:Label>
    <asp:TextBox ID="PhoneTextBox" CssClass="PhoneTextBox" runat="server" ValidationGroup="CustomerAuthorization"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="CustomerAuthorization" ControlToValidate="PhoneTextBox" runat="server" CssClass="Hide" ErrorMessage=""></asp:RequiredFieldValidator>

</div>
<div class="Div_Row">
    <asp:Label ID="Label2" runat="server" CssClass="Label" 
        Text="Authorization Code:" AssociatedControlID="AuthorizationTextBox"></asp:Label>
    <asp:TextBox ID="AuthorizationTextBox" CssClass="TextBox" runat="server" ValidationGroup="CustomerAuthorization"></asp:TextBox>
    <asp:RequiredFieldValidator ID="AuthorizationRequiredFieldValidator" ValidationGroup="CustomerAuthorization" ControlToValidate="AuthorizationTextBox" runat="server" CssClass="Hide" ErrorMessage=""></asp:RequiredFieldValidator>
</div>
    <asp:Label ID="AuthorizationStatusLabel" Visible="false" runat="server" CssClass="Validation" Text="Unable to activate your account, the account may already activated,<br /> or you have to fill the Telephone and authorization code correctly"></asp:Label>

<asp:LinkButton ID="AuthorizeLinkButton" runat="server" CssClass="Customer_LinkButton" 
    onclick="AuthorizeLinkButton_Click" ValidationGroup="CustomerAuthorization">Authorize</asp:LinkButton>


