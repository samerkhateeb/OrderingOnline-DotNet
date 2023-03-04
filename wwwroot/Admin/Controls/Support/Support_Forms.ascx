<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Support_Forms.ascx.cs" Inherits="Admin.Admin.Controls.Support.Support_Forms" %>


<kfg:collapsiblepanelextender ID="Form_CollapsiblePanelExtender"  runat="server"
        TargetControlID="FormBodyPanel" 
        TextLabelID="FormHeaderLabel" 
        CollapseControlID="FormHeaderPanel" 
        ExpandControlID="FormHeaderPanel" 
        ImageControlID="FormHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        ExpandedSize="390" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="FormHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="FormHeaderImage" runat="server" Width="14" Height="14" />
        Form Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="FormHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="FormBodyPanel" runat="server" SkinID="LabelHeader">
    <br />
<asp:Label ID="Label1" runat="server" Text="Subject:"></asp:Label>
<asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ErrorMessage="*" ForeColor="Red" ControlToValidate="NameTextBox"></asp:RequiredFieldValidator>
<p>
    &nbsp;</p>
<asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
<asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ErrorMessage="*" ForeColor="Red" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
    ControlToValidate="EmailTextBox" ErrorMessage="Please enter a valid email." 
    ForeColor="#CC3300" 
    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
<p>
   <br /></p>
<asp:Panel ID="CategoryPanel" runat="server">

    <asp:Label ID="Label3" runat="server" Text="Category:"></asp:Label>
    <asp:DropDownList ID="CategoryDropdownList" runat="server">
    </asp:DropDownList>
    <p>
    &nbsp;</p>
</asp:Panel>

<asp:Label ID="Label4" runat="server" Text="Comments:"></asp:Label>
<asp:TextBox ID="CommentTextBox" runat="server" SkinID="TextBox_Area" 
    TextMode="MultiLine"></asp:TextBox>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Send" />
    <asp:Label ID="MassageLable" runat="server" Visible="False" Width="700px"></asp:Label>
</p>

</asp:Panel>