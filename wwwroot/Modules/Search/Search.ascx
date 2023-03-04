<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="Search.Search" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="KFG" %>

<KFG:TextBoxWatermarkExtender ID="SearchTextBox_TextBoxWatermarkExtender" 
    runat="server" Enabled="True" TargetControlID="SearchTextBox" 
    WatermarkText="البحث داخل الموقع" WatermarkCssClass="SearchWaterMark" >
</KFG:TextBoxWatermarkExtender>

<div class="SearchDiv">

<div class="FloatLeft">
    <asp:ImageButton ID="SearchButton" runat="server" onclick="SearchButton_Click" CssClass="SearchButton" 
                     ImageUrl="~/images/spaceball.gif" ValidationGroup="Search" />
</div>

<div class="FloatLeft">
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="SearchTextBox" ErrorMessage="*" SkinID="NoSkin"
                ValidationGroup="Search" CssClass="Hide" ForeColor="#5c2828" ></asp:RequiredFieldValidator>
</div>

  <div class="SearchBG FloatLeft">
<asp:TextBox ID="SearchTextBox" runat="server" 
          ValidationGroup="Search" CssClass="SearchTextBox"></asp:TextBox>
</div>





</div>

