<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Controls_Details.ascx.cs" Inherits="Admin.Admin.Controls.Controls.Controls_Details" %>


<%@ Register src="../MediaUpload/MediaUpload.ascx" tagname="MediaUpload" tagprefix="uc1" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Name :" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="red"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="Description :" AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox" runat="server" Checked="True" 
            TextMode="MultiLine" SkinID="TextBox_Area"  />
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="Thumbnail :" ></asp:Label>
        <%--<asp:TextBox ID="ThumbnailTextBox" runat="server" style="direction: ltr"></asp:TextBox>--%>
    <uc1:MediaUpload ID="MediaUploadImage" runat="server" />
    </div>
    
    <div class="Div_Row" style="direction: ltr">
    <asp:Label ID="Label7" runat="server" Text="Path :" AssociatedControlID="PathDropDownList"></asp:Label>
    
        <asp:dropdownlist ID="PathDropDownList" runat="server">
        
        </asp:dropdownlist>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Labe8" runat="server" Text="Status :" AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true" 
        style="direction: ltr"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting :" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
        
    </div>

    <div class="Div_Row">

    <asp:Label ID="Label10" runat="server" Text="ChildID:"></asp:Label>
    <asp:DropDownList ID="ChildIDDropDownList" runat="server">
        </asp:DropDownList>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />

    
    