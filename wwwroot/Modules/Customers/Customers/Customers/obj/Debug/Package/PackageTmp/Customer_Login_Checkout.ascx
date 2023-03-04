<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customer_Login_Checkout.ascx.cs" Inherits="Customers.Customer_Login_Checkout" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="KFG" %>--%>

<asp:Panel ID="LoginPanel" CssClass="MarginCenter" Visible="false" runat="server">

<%--<div class="Login_Header_Checkout" runat="server" id="ContainerHeaderControl">Order Online</div>--%>
<div class="Login_Div_Checkout">
    <asp:Label ID="LoginTtitleLabel" CssClass="Login_Header_Inside_Checkout" runat="server">Login First</asp:Label>

<asp:Panel ID="LoginControlsPanel" runat="server">
<br class="ClearBoth" />
<div class="FloatLeft">
<div class="Login_Row_Div_Checkout">
<asp:Label ID="Label1" runat="server" AssociatedControlID="EmailTextBox" CssClass="Login_Label_Checkout" >Email:</asp:Label>
<asp:TextBox ID="EmailTextBox" runat="server" CssClass="Login_TextBox_Checkout" ValidationGroup="LoginGroup"></asp:TextBox>
    <kfg:textboxwatermarkextender ID="EmailTextBox_TextBoxWatermarkExtender" runat="server" TargetControlID="EmailTextBox" WatermarkText="Enter You Email" >
    </kfg:textboxwatermarkextender>

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
    ControlToValidate="EmailTextBox" Display="Dynamic" CssClass="Login_Validation2" SkinID="NoSkin"
    ErrorMessage="Please enter correct email" ValidationGroup="LoginGroup" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
</div>

<div class="Login_Row_Div_Checkout">
    <asp:Label ID="Label2" runat="server" AssociatedControlID="PasswordTextBox" CssClass="Login_Label_Checkout" >Password:</asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" 
        CssClass="Login_TextBox_Checkout"></asp:TextBox>
    <kfg:textboxwatermarkextender ID="PasswordTextBox_TextBoxWatermarkExtender" 
        runat="server" TargetControlID="PasswordTextBox" 
        WatermarkText="Password ..." >
    </kfg:textboxwatermarkextender>
    
</div>
     <asp:Label ID="LogoutStatusLabel" Visible="false" CssClass="Login_Result_Fail" runat="server" ></asp:Label>

</div>
<div class="FloatLeft">
    <asp:Button ID="LoginButton" ValidationGroup="LoginGroup" CssClass="Login_LinkButton_Checkout" Text="Login" onclick="LoginLinkButton_Click" runat="server"  />
</div>
<div class="SignUp_Div">
<a href="/Portals/CustomerRegistration" class="Signup_LinkButton">Sign up !</a>
</div>
    <%--<asp:LinkButton ID="LoginLinkButton" runat="server" ValidationGroup="LoginGroup" CssClass="Login_LinkButton" onclick="LoginLinkButton_Click">Login</asp:LinkButton>--%>
    </asp:Panel>

    <asp:Panel ID="LoginUserPanel" runat="server">
        <asp:Label ID="WelcomeLabel" CssClass="Login_Label2" runat="server" ></asp:Label>

        <asp:Panel ID="ActivationPanel" Visible="false" runat="server">
            <asp:Label ID="Label3" CssClass="Login_Label3" runat="server" Text="your account is not activated"></asp:Label>
            <asp:LinkButton ID="ActivateLinkButton" CssClass="Login_LinkButton3" 
                runat="server" onclick="ActivateLinkButton_Click">activate Now?</asp:LinkButton>
        </asp:Panel>
        
    </asp:Panel>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="Hide" 
    ControlToValidate="EmailTextBox" Display="Dynamic" ValidationGroup="LoginGroup"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="Hide"
    ControlToValidate="PasswordTextBox" Display="Dynamic" ValidationGroup="LoginGroup"></asp:RequiredFieldValidator>
</div>

</asp:Panel>






