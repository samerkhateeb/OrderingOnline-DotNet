<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings_Details.ascx.cs" Inherits="Admin.Admin.Controls.Settings.Settings_Details" %>


    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="HotNews Title:" 
            AssociatedControlID="HotNewsTitleTextBox"></asp:Label>
    <asp:TextBox ID="HotNewsTitleTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="HotNews Count:" 
            AssociatedControlID="HotNewsCountTextBox"></asp:Label>
    <asp:TextBox ID="HotNewsCountTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="LastNews Title:" 
            AssociatedControlID="LastNewsTitleTextBox"></asp:Label>
    <asp:TextBox ID="LastNewsTitleTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="LastNews Count:" 
            AssociatedControlID="LastNewsCountTextBox"></asp:Label>
   <asp:TextBox ID="LastNewsCountTextBox" runat="server">0</asp:TextBox>
   </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="Most Status:" 
            AssociatedControlID="MostStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MostStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="MostEmail Count:" 
            AssociatedControlID="MostEmailCountTextBox"></asp:Label>
    <asp:TextBox ID="MostEmailCountTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="MostEmail Status:" 
            AssociatedControlID="MostEmailStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MostEmailStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="MostComment Count:" 
            AssociatedControlID="MostCommentCountTextBox"></asp:Label>
    <asp:TextBox ID="MostCommentCountTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label12" runat="server" Text="MostComment Status:" 
            AssociatedControlID="MostCommentStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MostCommentStatusCheckBox" runat="server"></asp:CheckBox>
    </div>


    <div class="Div_Row">
    <asp:Label ID="Label13" runat="server" Text="MostVISIT Count:" 
            AssociatedControlID="MostVISITCountTextBox"></asp:Label>
    <asp:TextBox ID="MostVISITCountTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label14" runat="server" Text="MostVisit Status:" 
            AssociatedControlID="MostVisitStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MostVisitStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="Discussions Title:" 
            AssociatedControlID="DiscussionsTitleTextBox"></asp:Label>
    <asp:TextBox ID="DiscussionsTitleTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="Discussions Count:" 
            AssociatedControlID="DiscussionsCountTextBox"></asp:Label>
    <asp:TextBox ID="DiscussionsCountTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Discussions Status:" AssociatedControlID="DiscussionsStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="DiscussionsStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
