<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customer_Registration.ascx.cs" Inherits="Customers.Customer_Registration" %>
<%@ Register src="AddressDetails.ascx" tagname="AddressDetails" tagprefix="KFG" %>
<script src="/Modules/Customers/scripts/AddressDetails.js" type="text/javascript"></script>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="KFG" %>--%>

 <asp:Label ID="StatusLabel" Visible="false" runat="server" CssClass="Customer_ResultLabel" ValidationGroup="CustomerRegistration" Text="Thanks for registration in our webstie, please check your Mobile and Email to activate your account">
</asp:Label>


<div class="Customer_Registration_Title">Registration Form</div>
<div class="Customer_Registration_Title2">Sign up for Kabab-ji to place your order</div>
<div class="Customer_Registration_Title3">Customer Details</div>
<div class="Div_Row">
    <asp:Label ID="Label1" runat="server" AssociatedControlID="NameTextBox" CssClass="Label" Text="Name (*):" ValidationGroup="CustomerRegistration"></asp:Label>
    <asp:TextBox ID="NameTextBox" CssClass="TextBox" runat="server" ValidationGroup="CustomerRegistration"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" Display="Dynamic" ErrorMessage="*" ValidationGroup="CustomerRegistration" 
        SetFocusOnError="True"  ></asp:RequiredFieldValidator>
</div>

<div class="Div_Row">
 <asp:Label ID="Label2" runat="server" AssociatedControlID="TelephoneTextBox" Text="Phone Number (*):" CssClass="Label"></asp:Label>
 <asp:Label ID="Label17" runat="server" Text="+ 965 - " CssClass="Label2"></asp:Label>
    <asp:TextBox ID="TelephoneTextBox" CssClass="TextBox2" runat="server" ValidationGroup="CustomerRegistration" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ValidationGroup="CustomerRegistration" ControlToValidate="TelephoneTextBox"></asp:RequiredFieldValidator>
 <asp:Label ID="Label18" runat="server"   Text="Note: We will sms you the activation code for the confirmation of your registration" CssClass="Customer_Label"></asp:Label>
</div>

<div class="Div_Row">
 <asp:Label ID="Label14" runat="server" AssociatedControlID="EmailTextBox" CssClass="Label" Text="Your Email (*):"></asp:Label>
    <asp:TextBox ID="EmailTextBox" CssClass="TextBox" runat="server" ValidationGroup="CustomerRegistration"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="*" 
        SetFocusOnError="True" ValidationGroup="CustomerRegistration"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ValidationGroup="CustomerRegistration"
        ControlToValidate="EmailTextBox" 
        ErrorMessage="&lt;br class='ClearBoth' /&gt;Please type the email correctly" Display="Dynamic"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
</div>

<div class="Div_Row">
 <asp:Label ID="Label15" runat="server"  AssociatedControlID="PasswordTextBox" CssClass="Label" Text="Password (*):"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" CssClass="TextBox" runat="server" TextMode="Password" ValidationGroup="CustomerRegistration"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="PasswordreTextBox" Display="Dynamic" ErrorMessage="*" 
        SetFocusOnError="True" ValidationGroup="CustomerRegistration"></asp:RequiredFieldValidator>
</div>

<div class="Div_Row">
 <asp:Label ID="Label16" runat="server" AssociatedControlID="PasswordreTextBox" CssClass="Label" Text="Confirm Password:">
    </asp:Label>
    <asp:TextBox ID="PasswordreTextBox" CssClass="TextBox" runat="server" TextMode="Password" ValidationGroup="CustomerRegistration"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="CustomerRegistration"
        ControlToCompare="PasswordTextBox" ControlToValidate="PasswordreTextBox" 
        
        ErrorMessage="&lt;br class='ClearBoth' &gt;The password is not match, please type it again" 
        Display="Dynamic"></asp:CompareValidator>
</div>


<div class="Div_Row">
 <asp:Label ID="Label11" runat="server" AssociatedControlID="GenderDropDownList" Text="Gender:" CssClass="Label">
    </asp:Label>
    <asp:DropDownList ID="GenderDropDownList" CssClass="DropDownList" runat="server">
    <asp:ListItem Text="Select One" Value="0"></asp:ListItem>
    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
    <asp:ListItem Text="Female" Value="2"></asp:ListItem>    
    </asp:DropDownList>
</div>

<div class="Div_Row">
 <asp:Label ID="Label12" runat="server" AssociatedControlID="BirthDateTextBox" 
        Text=" Date Of Birth:" CssClass="Label"></asp:Label>
    <asp:TextBox ID="BirthDateTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
    
    <kfg:calendarextender ID="BirthDateTextBox_CalendarExtender" runat="server" TargetControlID="BirthDateTextBox" >
    </kfg:calendarextender>
</div>

<div class="Div_Row">
 <asp:Label ID="Label13" runat="server" AssociatedControlID="OccupationTextBox" Text="Occupation:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="OccupationTextBox" CssClass="TextBox" runat="server"></asp:TextBox>
</div>

<div class="Customer_Registration_Title3">Order Delivery Details
</div>
<%--<asp:UpdatePanel ID="GridsUpdatePanel" runat="server">
<ContentTemplate>

</ContentTemplate>
    </asp:UpdatePanel>--%>



    <KFG:AddressDetails ID="AddressDetailsControl" runat="server" />


<div class="Div_Row">
 <asp:Label ID="Label10" runat="server" AssociatedControlID="RemarksTextBox" Text="Remarks:" CssClass="Label">
    </asp:Label>
    <asp:TextBox ID="RemarksTextBox" CssClass="TextArea" runat="server" 
        Columns="20" TextMode="MultiLine"></asp:TextBox>
</div>








<asp:LinkButton ID="RegisterLinkButton" runat="server" CssClass="Customer_LinkButton"
    onclick="RegisterLinkButton_Click" ValidationGroup="CustomerRegistration">Register</asp:LinkButton>












<%--<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">LinkButton</asp:LinkButton>--%>













