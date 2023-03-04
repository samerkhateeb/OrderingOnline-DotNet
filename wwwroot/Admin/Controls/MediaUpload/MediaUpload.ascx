<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MediaUpload.ascx.cs" Inherits="Admin.Admin.Controls.MediaUpload.MediaUpload" %>
	
    <div class="Div_Row">
        <div class="Div_Row2">
        <asp:Panel ID="ThumbnailStatusPanel" runat="server" Visible="false">
            <asp:Label ID="Label25" runat="server" Text="Status:" SkinID="Label2" AssociatedControlID="ThumbnailStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="ThumbnailStatusCheckBox" runat="server"></asp:CheckBox>
            </asp:Panel>
        </div>
        <div class="Div_Row2">
        <asp:Panel ID="ThumbnailWidthPanel" runat="server" Visible="false">
            <asp:Label ID="Label29" runat="server" Text="Width:" SkinID="Label2" AssociatedControlID="ThumbnailWidthTextBox"></asp:Label>
            <asp:TextBox ID="ThumbnailWidthTextBox" SkinID="TextBox2" runat="server">0</asp:TextBox>
            </asp:Panel>
        </div>
        <div class="Div_Row2">
        <asp:Panel ID="ThumbnailHeightPanel" runat="server" Visible="false">
            <asp:Label ID="Label30" runat="server" Text="Height:" SkinID="Label2" AssociatedControlID="ThumbnailHeightTextBox"></asp:Label>
            <asp:TextBox ID="ThumbnailHeightTextBox" SkinID="TextBox2" runat="server">0</asp:TextBox>
            </asp:Panel>
        </div>
        <br class="ClearBoth" />
        <iframe id="MediaUploadFrame" runat="server" 
                        style="width:490px;height:150px;border-width:0; " frameborder="0" name="MediaUploadFrame">
			
		</iframe>

        <div class="Div_Row3">
        <asp:Panel ID="ThumbnailAltEngPanel" runat="server" Visible="false">
            <asp:Label ID="Label32" runat="server" Text="ThumbnailAltEng:" AssociatedControlID="ThumbnailAltEngTextBox"></asp:Label>
            <asp:TextBox ID="ThumbnailAltEngTextBox" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
        <div class="Div_Row3">
        <asp:Panel ID="ThumbnailAltArbPanel" runat="server" Visible="false">
            <asp:Label ID="Label31" runat="server" Text="ThumbnailAltArb:" AssociatedControlID="ThumbnailAltArbTextBox"></asp:Label>
            <asp:TextBox ID="ThumbnailAltArbTextBox" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
        </div>