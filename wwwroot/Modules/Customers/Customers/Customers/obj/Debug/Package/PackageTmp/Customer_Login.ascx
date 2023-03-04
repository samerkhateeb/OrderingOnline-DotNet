<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customer_Login.ascx.cs" Inherits="Customers.Customer_Login" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="KFG" %>--%>
<div class="MarginCenter">
<div class="Login_Header" runat="server" id="ContainerHeaderControl">Order Online</div>
<div class="Login_Div">
<div class="Login_Row_Div">
    <asp:Label ID="LoginTtitleLabel" CssClass="Login_Header_Inside" runat="server" Text="Don’t Have a Kabab-ji Account?" ></asp:Label>
</div>
<a href="/Portals/CustomerRegistration" class="Login_LinkButton_CreateAccount"> Create a Kabab-ji Account </a>
<asp:Panel ID="LoginControlsPanel" runat="server">

<div class="Login_Row_Div">
<asp:Label ID="Label1" runat="server" AssociatedControlID="EmailTextBox" CssClass="Login_Label" Text="Email:"></asp:Label>
<asp:TextBox ID="EmailTextBox" runat="server" CssClass="Login_TextBox" ValidationGroup="LoginGroup"></asp:TextBox>
    <kfg:textboxwatermarkextender ID="EmailTextBox_TextBoxWatermarkExtender" 
        runat="server" TargetControlID="EmailTextBox" 
        WatermarkText="Enter You Email" >
    </kfg:textboxwatermarkextender>

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
    ControlToValidate="EmailTextBox" Display="Dynamic" CssClass="Login_Validation" SkinID="NoSkin"
    ErrorMessage="Please enter correct email" ValidationGroup="LoginGroup" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="White"></asp:RegularExpressionValidator>
</div>
<div class="Login_Row_Div">
    <asp:Label ID="Label2" runat="server" AssociatedControlID="PasswordTextBox" CssClass="Login_Label" Text="Password:"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" 
        CssClass="Login_TextBox"></asp:TextBox>
    <kfg:textboxwatermarkextender ID="PasswordTextBox_TextBoxWatermarkExtender" 
        runat="server" TargetControlID="PasswordTextBox" 
        WatermarkText="Password ..." >
    </kfg:textboxwatermarkextender>
    
</div>
     <asp:Label ID="LogoutStatusLabel" Visible="false" CssClass="Login_Header_Inside" runat="server" Text="Don’t Have a Kabab-ji Account?" ></asp:Label>
    <asp:Button ID="LoginButton" ValidationGroup="LoginGroup" CssClass="Login_LinkButton" Text="Login" onclick="LoginLinkButton_Click" runat="server"  />
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

</div>

<br class="ClearBoth" />