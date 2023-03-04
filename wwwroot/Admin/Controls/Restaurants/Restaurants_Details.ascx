<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Restaurants_Details.ascx.cs" Inherits="Admin.Admin.Controls.Restaurants.Restaurants_Details" %>


<%@ Register src="../MediaUpload/MediaUpload.ascx" tagname="MediaUpload" tagprefix="uc1" %>
<%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="uc2" %>


<div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Name:" 
            AssociatedControlID="NameTextBox"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
 </div>

  <div class="Div_Row">
    <asp:Label ID="Label24" runat="server" Text="Status:" 
            AssociatedControlID="StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label27" runat="server" Text="Sorting:" 
            AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>
          
    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="Description:" 
            AssociatedControlID="DescriptionTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionTextBox"  runat="server" TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

 <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="Body:" ></asp:Label>
    <br class="ClearBoth" />
        <uc2:HTMLEditor ID="BodyHTMLEditor" runat="server" />
    </div>

 <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="PostalCode:" 
            AssociatedControlID="PostalCodeTextBox"></asp:Label>
    <asp:TextBox ID="PostalCodeTextBox" runat="server"></asp:TextBox>
 </div>

 <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="DineinMenu:" ></asp:Label>
    
        <uc1:MediaUpload ID="MediaDineinMenu" runat="server" />
    
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="PickupMenu:" ></asp:Label>
    
        <uc1:MediaUpload ID="MediaPickupMenu" runat="server" />
    
    </div>

    <div class="Div_Row">
    <asp:Label ID="Labelx8" runat="server" Text="Thumbnail:" ></asp:Label>
    
        <uc1:MediaUpload ID="MediaThumbnail" runat="server" />
    
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label21" runat="server" Text="ThumbnailStatus:" 
            AssociatedControlID="ThumbnailStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="ThumbnailStatusCheckBox" runat="server"></asp:CheckBox>
    </div>


     <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Thumbnail2:" ></asp:Label>
    
        <uc1:MediaUpload ID="MediaThumbnail2" runat="server" />
    
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Thumbnail2Status:" 
            AssociatedControlID="Thumbnail2StatusCheckBox"></asp:Label>
    <asp:CheckBox ID="Thumbnail2StatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label22" runat="server" Text="MapStatus:" 
            AssociatedControlID="MapStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MapStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Labelx5" runat="server" Text="Time:" 
            AssociatedControlID="TimeTextBox"></asp:Label>
    <asp:TextBox ID="TimeTextBox" runat="server" SkinID="TextBox_Area" 
            TextMode="MultiLine"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:label runat="server" text="RestaurantLocationID:"></asp:label>
    <asp:DropDownList ID="LocationIDDropDownList" runat="server">
    </asp:DropDownList>
    </div>

      <div class="Div_Row">
            <asp:Label ID="Label28" runat="server" Text="RestaurantPlace:"></asp:Label>
        <asp:RadioButtonList ID="PlaceRadioButtonList" runat="server" 
            RepeatDirection="vertical">
            <asp:ListItem Selected="True" Value="0">In London</asp:ListItem>
            <asp:ListItem Value="1">Outer London</asp:ListItem>
        </asp:RadioButtonList>
         <br class="ClearBoth" />
     </div>

     <div class="Div_Row">
    <asp:Label ID="Labelx4" runat="server" Text="Latitude:" 
            AssociatedControlID="LatitudeTextBox"></asp:Label>
    <asp:TextBox ID="LatitudeTextBox" runat="server"></asp:TextBox>
 </div>

 <div class="Div_Row">
    <asp:Label ID="Labely5" runat="server" Text="Longitude:" 
            AssociatedControlID="LongitudeTextBox"></asp:Label>
    <asp:TextBox ID="LongitudeTextBox" runat="server"></asp:TextBox>
 </div>

 <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Address:" 
            AssociatedControlID="AddressTextBox"></asp:Label>
    <asp:TextBox ID="AddressTextBox" runat="server" SkinID="TextBox_Area" 
            TextMode="MultiLine"></asp:TextBox>
    </div>

    <div class="Div_Row">
   
        <asp:Label ID="Label453" runat="server" Text="SiteMap Status:"></asp:Label>
        <asp:CheckBox ID="SiteMapCheckBox" runat="server" />
        </div>
      <div class="Div_Row">
        <asp:Label ID="Label452" runat="server" Text="SiteMap Sorting:"></asp:Label>
        <asp:TextBox ID="SiteMapSortingTextBox" runat="server"></asp:TextBox>

      </div>

 <asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />
