<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Categories_Details.ascx.cs" Inherits="Admin.Admin.Controls.Categories.Categories_Details" %>


<%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="uc1" %>
<%@ Register src="../MediaUpload/MediaUpload.ascx" tagname="MediaUpload" tagprefix="uc2" %>

<kfg:collapsiblepanelextender ID="General_CollapsiblePanelExtender"  runat="server"
        TargetControlID="GeneralBodyPanel" 
        TextLabelID="GeneralHeaderLabel" 
        CollapseControlID="GeneralHeaderPanel" 
        ExpandControlID="GeneralHeaderPanel" 
        ImageControlID="GeneralHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        ExpandedSize="390" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="GeneralHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="GeneralHeaderImage" runat="server" Width="14" Height="14" />
        General Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="GeneralHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="GeneralBodyPanel" runat="server" SkinID="LabelHeader">

    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="NameEng:" 
            AssociatedControlID="NameEngTextBox"></asp:Label>
    <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="NameArb:" 
            AssociatedControlID="NameArbTextBox"></asp:Label>
   <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
   </div>

   <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="TypeID:" 
            AssociatedControlID="TypeIDDropDownList"></asp:Label>
    <asp:DropDownList ID="TypeIDDropDownList" runat="server"></asp:DropDownList>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label43" runat="server" Text="MenuPosition:" 
            AssociatedControlID="MenuPositionDropDownList"></asp:Label>
    <asp:DropDownList ID="MenuPositionDropDownList" runat="server">
        <asp:ListItem Value="0">None</asp:ListItem>
        <asp:ListItem Value="1">Top</asp:ListItem>
        <asp:ListItem Value="2">Both</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label37" runat="server" Text="Status:" 
                AssociatedControlID="StatusCheckBox"></asp:Label>
       <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
         </div>

    <div class="Div_Row">
    <asp:Label ID="Label20" runat="server" Text="Sorting:" 
            AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
     </div>


    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="DescriptionEng:" 
            AssociatedControlID="DescriptionEngTextBox"></asp:Label>
   <asp:TextBox ID="DescriptionEngTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
   </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="DescriptionArb:" 
            AssociatedControlID="DescriptionArbTextBox"></asp:Label>
   
    <asp:TextBox ID="DescriptionArbTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
     </div>

   
   </asp:Panel>


  <kfg:collapsiblepanelextender id="ThumbnailPanel_CollapsiblePanelExtender" runat="server"
    targetcontrolid="ThumbnailBodyPanel"
    textlabelid="ThumbnailHeaderLabel"
    collapsecontrolid="ThumbnailHeaderPanel"
    expandcontrolid="ThumbnailHeaderPanel"
    imagecontrolid="ThumbnailHeaderImage"
    collapsedsize="0"
    collapsedtext="Show Details"
    collapsed="false"
    expandedsize="0"
    expandedtext="Hide Details"
    suppresspostback="True"
    collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
    <asp:Panel ID="ThumbnailHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="ThumbnailHeaderImage" runat="server" Width="14" Height="14" />
        Thumbnail Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="ThumbnailHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="ThumbnailBodyPanel" runat="server" SkinID="LabelHeader">
    <uc2:MediaUpload ID="MediaUploadImage" runat="server" />
    <br />
    </asp:Panel>

<kfg:collapsiblepanelextender id="Thumbnail2Panel_CollapsiblePanelExtender" runat="server"
    targetcontrolid="Thumbnail2BodyPanel"
    textlabelid="Thumbnail2HeaderLabel"
    collapsecontrolid="Thumbnail2HeaderPanel"
    expandcontrolid="Thumbnail2HeaderPanel"
    imagecontrolid="Thumbnail2HeaderImage"
    collapsedsize="0"
    collapsedtext="Show Details"
    expandedsize="0"
    expandedtext="Hide Details"
    suppresspostback="True"
    collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
    <asp:Panel ID="Thumbnail2HeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="Thumbnail2HeaderImage" runat="server" Width="14" Height="14" />
         Thumbnail2 Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="Thumbnail2HeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="Thumbnail2BodyPanel" runat="server" SkinID="LabelHeader">
        <uc2:MediaUpload ID="MediaUploadImage2" runat="server" />
    <br />
    </asp:Panel>

     <div class="Div_Row">
         <asp:Label ID="Label9" runat="server" Text="ThumbnailBodyID"></asp:Label>
         <asp:RadioButtonList ID="ThumBodyIDRadioButtonList" runat="server">
             <asp:ListItem Value="1" Selected="True">Thumbnail</asp:ListItem>
             <asp:ListItem Value="2">Thumbnail2</asp:ListItem>
         </asp:RadioButtonList>
         <br class="ClearBoth" />
     </div>


  <%-- <kfg:collapsiblepanelextender ID="Body_CollapsiblePanelExtender"  runat="server"
        TargetControlID="BodiesBodyPanel" 
        TextLabelID="BodiesHeaderLabel" 
        CollapseControlID="BodiesHeaderPanel" 
        ExpandControlID="BodiesHeaderPanel" 
        ImageControlID="BodiesHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        ExpandedSize="700" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>--%>

    <asp:Panel ID="BodiesHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="BodiesHeaderImage" runat="server" Width="14" Height="14" />
        Body Panel<%--&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="BodiesHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)--%></asp:Panel>
    <asp:Panel ID="BodiesBodyPanel" runat="server" SkinID="LabelHeader">

    <div class="Div_Row">
    <asp:Label ID="Label6" runat="server" Text="BodyEng:"></asp:Label>
    <uc1:HTMLEditor ID="BodyEngHTMLEditor" runat="server" />
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="BodyArb:"></asp:Label>
    <uc1:HTMLEditor ID="BodyArbHTMLEditor" runat="server" />
    </div>
    </asp:Panel>


    

     <kfg:collapsiblepanelextender ID="Advance_CollapsiblePanelExtender"  runat="server"
        TargetControlID="AdvanceBodyPanel" 
        TextLabelID="AdvanceHeaderLabel" 
        CollapseControlID="AdvanceHeaderPanel" 
        ExpandControlID="AdvanceHeaderPanel" 
        ImageControlID="AdvanceHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        Collapsed="true"
        ExpandedSize="400" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="AdvanceHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="AdvanceHeaderImage" runat="server" Width="14" Height="14" />
        Advance Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="AdvanceHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="AdvanceBodyPanel" runat="server" SkinID="LabelHeader">

    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="Parent:" 
            AssociatedControlID="PageIDDropDownList"></asp:Label>
   <asp:DropDownList ID="PageIDDropDownList" runat="server"></asp:DropDownList>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="StaticLink:" 
            AssociatedControlID="StaticLinkTextBox"></asp:Label>
    <asp:TextBox ID="StaticLinkTextBox" runat="server"></asp:TextBox>
   </div>

    <div class="Div_Row Hide">
    <asp:Label ID="Label11" runat="server" Text="Icon URL:" 
            AssociatedControlID="IconURLTextBox"></asp:Label>
   <asp:TextBox ID="IconURLTextBox" runat="server"></asp:TextBox>
    </div>

   <div class="Div_Row">
    <asp:Label ID="Label12" runat="server" Text="HotNews Status:" 
            AssociatedControlID="HotNewsStatusCheckBox"></asp:Label>
   <asp:CheckBox ID="HotNewsStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label13" runat="server" Text="LastNews Status:" 
            AssociatedControlID="LastNewsStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="LastNewsStatusCheckBox" runat="server"></asp:CheckBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label21" runat="server" Text="Date:" 
            AssociatedControlID="DateTextBox"></asp:Label>
    <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label42" runat="server" Text="MenuSorting:" 
            AssociatedControlID="MenuSortingTextBox"></asp:Label>
    <asp:TextBox ID="MenuSortingTextBox" runat="server">1</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label22" runat="server" Text="CountVisit:" 
            AssociatedControlID="CountVisitTextBox"></asp:Label>
   <asp:TextBox ID="CountVisitTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label23" runat="server" Text="CountEmail:" 
            AssociatedControlID="CountEmailTextBox"></asp:Label>
   <asp:TextBox ID="CountEmailTextBox" runat="server">0</asp:TextBox>
     </div>

    <div class="Div_Row">
    <asp:Label ID="Label24" runat="server" Text="CountParticipate:" 
            AssociatedControlID="CountParticipateTextBox"></asp:Label>
    <asp:TextBox ID="CountParticipateTextBox" runat="server">0</asp:TextBox>
     </div>

    <div class="Div_Row">
    <asp:Label ID="Label44" runat="server" Text="SkinID:" 
            AssociatedControlID="SkinIDRadioButtonList"></asp:Label>
    <asp:RadioButtonList ID="SkinIDRadioButtonList" runat="server" 
            RepeatDirection="Horizontal">
        <asp:ListItem Value="1" Selected="True">Skin1</asp:ListItem>
        <asp:ListItem Value="2">Skin2</asp:ListItem>
        <asp:ListItem Value="3">Skin3</asp:ListItem>
        <asp:ListItem Value="4">Skin4</asp:ListItem>
        </asp:RadioButtonList>
        <br class="ClearBoth" />
    </div>
    </asp:Panel>

    <kfg:collapsiblepanelextender ID="Home_CollapsiblePanelExtender"  runat="server"
        TargetControlID="HomeBodyPanel" 
        TextLabelID="HomeHeaderLabel" 
        CollapseControlID="HomeHeaderPanel" 
        ExpandControlID="HomeHeaderPanel" 
        ImageControlID="HomeHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        Collapsed="true"
        ExpandedSize="250" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="HomeHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="HomeHeaderImage" runat="server" Width="14" Height="14" />
        HomePage Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="HomeHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="HomeBodyPanel" runat="server" SkinID="LabelHeader">

    <div class="Div_Row">
    <asp:Label ID="Label18" runat="server" Text="Mid Status:" 
            AssociatedControlID="MidStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="MidStatusCheckBox" runat="server"></asp:CheckBox>
    
    <asp:Label ID="Label19" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="MidRowsTextBox"></asp:Label>
    <asp:TextBox ID="MidRowsTextBox" SkinID="TextBox2" runat="server">5</asp:TextBox>
     </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label31" runat="server" Text="Bottom Status:" 
            AssociatedControlID="BottomStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="BottomStatusCheckBox" runat="server"></asp:CheckBox>
    
    <asp:Label ID="Label32" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="BottomRowsTextBox"></asp:Label>
    <asp:TextBox ID="BottomRowsTextBox" SkinID="TextBox2" runat="server">5</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label33" runat="server" Text="Left Status:" 
            AssociatedControlID="LeftStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="LeftStatusCheckBox" runat="server"></asp:CheckBox>
    
    <asp:Label ID="Label34" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="LeftRowsTextBox"></asp:Label>
    <asp:TextBox ID="LeftRowsTextBox" SkinID="TextBox2" runat="server" value="5"></asp:TextBox>
     </div>

    <div class="Div_Row" style="direction: ltr">
    <asp:Label ID="Label35" runat="server" Text="SubPage Status:" 
            AssociatedControlID="SubPageStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="SubPageStatusCheckBox" runat="server"></asp:CheckBox>
     
    <asp:Label ID="Label36" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="SubPageRowsTextBox"></asp:Label>
    <asp:TextBox ID="SubPageRowsTextBox" SkinID="TextBox2" runat="server">5</asp:TextBox>
    </div>

    <div class="Div_Row Hide">
    <asp:Label ID="Label38" runat="server" Text="LeftImage:" 
            AssociatedControlID="LeftImageCheckBox"></asp:Label>
    <asp:CheckBox ID="LeftImageCheckBox" runat="server"></asp:CheckBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label39" runat="server" Text="TabLeft Status:" 
            AssociatedControlID="TabLeftStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="TabLeftStatusCheckBox" runat="server"></asp:CheckBox>

    <asp:Label ID="Label26" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="TabLeftRowsTextBox"></asp:Label>
    <asp:TextBox ID="TabLeftRowsTextBox" SkinID="TextBox2" runat="server">5</asp:TextBox>

    <asp:Label ID="Label25" runat="server" Text="Sorting:" SkinID="Label2"
            AssociatedControlID="TabLeftSortingTextBox"></asp:Label>
    <asp:TextBox ID="TabLeftSortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>
    
    <asp:Label ID="Label40" runat="server" Text="Active:" SkinID="Label2"
            AssociatedControlID="TabLeftActiveCheckBox"></asp:Label>
    <asp:CheckBox ID="TabLeftActiveCheckBox" runat="server" ></asp:CheckBox>
    
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label14" runat="server" Text="Tabs Status:" 
            AssociatedControlID="TabsStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="TabsStatusCheckBox" runat="server"></asp:CheckBox>

    <asp:Label ID="Label16" runat="server" Text="Rows:" SkinID="Label2"
            AssociatedControlID="TabsRowsTextBox"></asp:Label>
    <asp:TextBox ID="TabsRowsTextBox" SkinID="TextBox2" runat="server" >5</asp:TextBox>
    
    <asp:Label ID="Label17" runat="server" Text="Sorting:" SkinID="Label2"
            AssociatedControlID="TabsSortingTextBox"></asp:Label>
    <asp:TextBox ID="TabsSortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>

    <asp:Label ID="Label15" runat="server" Text="Active:" SkinID="Label2"
            AssociatedControlID="TabsActiveCheckBox"></asp:Label>
    <asp:CheckBox ID="TabsActiveCheckBox" runat="server"></asp:CheckBox>
    
   </div>
   </asp:Panel>

    <kfg:collapsiblepanelextender ID="Types_CollapsiblePanelExtender"  runat="server"
        TargetControlID="TypesBodyPanel" 
        TextLabelID="TypesHeaderLabel" 
        CollapseControlID="TypesHeaderPanel" 
        ExpandControlID="TypesHeaderPanel" 
        ImageControlID="TypesHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        Collapsed="true"
        ExpandedSize="470" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="TypesHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="TypesHeaderImage" runat="server" Width="14" Height="14" />
        Types Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="TypesHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="TypesBodyPanel" runat="server" SkinID="LabelHeader">

    <div class="Div_Row">
        <div class="Div_Row3">
            <asp:Label ID="Label45" runat="server" Text="Type1 NameArb:" 
            AssociatedControlID="Type1_NameArbTextBox"></asp:Label>
            <asp:TextBox ID="Type1_NameArbTextBox" runat="server"></asp:TextBox>
        </div>

        <div class="Div_Row3">
            <asp:Label ID="Label46" runat="server" Text="Type1 NameEng:" 
            AssociatedControlID="Type1_NameEngTextBox"></asp:Label>
            <asp:TextBox ID="Type1_NameEngTextBox" runat="server"></asp:TextBox>
        </div>
    
        <div class="Div_Row3">
            <asp:Label ID="Label48" runat="server" Text="Type1 Status:" 
            AssociatedControlID="Type1_StatusCheckBox"></asp:Label>
            <div class="Div_Row_Inside2">
                 <asp:CheckBox ID="Type1_StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
                 <asp:Label ID="Label47" runat="server" Text="Sorting:" SkinID="Label2"
                 AssociatedControlID="Type1_SortingTextBox"></asp:Label>
                 <asp:TextBox ID="Type1_SortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>
            </div>
            </div>
        <br class="ClearBoth" />
    </div>
     
     <div class="Div_Row">
        <div class="Div_Row3">
            <asp:Label ID="Label245" runat="server" Text="Type2 NameArb:" 
            AssociatedControlID="Type2_NameArbTextBox"></asp:Label>
            <asp:TextBox ID="Type2_NameArbTextBox" runat="server"></asp:TextBox>
        </div>

        <div class="Div_Row3">
            <asp:Label ID="Label246" runat="server" Text="Type2 NameEng:" 
            AssociatedControlID="Type2_NameEngTextBox"></asp:Label>
            <asp:TextBox ID="Type2_NameEngTextBox" runat="server"></asp:TextBox>
        </div>
    
        <div class="Div_Row3">
            <asp:Label ID="Label248" runat="server" Text="Type2 Status:" 
            AssociatedControlID="Type2_StatusCheckBox"></asp:Label>
            <div class="Div_Row_Inside2">
                 <asp:CheckBox ID="Type2_StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
                 <asp:Label ID="Label247" runat="server" Text="Sorting:" SkinID="Label2"
                 AssociatedControlID="Type2_SortingTextBox"></asp:Label>
                 <asp:TextBox ID="Type2_SortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>
            </div>
            </div>
        <br class="ClearBoth" />
    </div>

    <div class="Div_Row">
        <div class="Div_Row3">
            <asp:Label ID="Label345" runat="server" Text="Type3 NameArb:" 
            AssociatedControlID="Type3_NameArbTextBox"></asp:Label>
            <asp:TextBox ID="Type3_NameArbTextBox" runat="server"></asp:TextBox>
        </div>

        <div class="Div_Row3">
            <asp:Label ID="Label346" runat="server" Text="Type3 NameEng:" 
            AssociatedControlID="Type3_NameEngTextBox"></asp:Label>
            <asp:TextBox ID="Type3_NameEngTextBox" runat="server"></asp:TextBox>
        </div>
    
        <div class="Div_Row3">
            <asp:Label ID="Label348" runat="server" Text="Type3 Status:" 
            AssociatedControlID="Type3_StatusCheckBox"></asp:Label>
            <div class="Div_Row_Inside2">
                 <asp:CheckBox ID="Type3_StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
                 <asp:Label ID="Label347" runat="server" Text="Sorting:" SkinID="Label2"
                 AssociatedControlID="Type3_SortingTextBox"></asp:Label>
                 <asp:TextBox ID="Type3_SortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>
            </div>
            </div>
        <br class="ClearBoth" />
    </div>


    <div class="Div_Row">
        <div class="Div_Row3">
            <asp:Label ID="Label445" runat="server" Text="Type4 NameArb:" 
            AssociatedControlID="Type4_NameArbTextBox"></asp:Label>
            <asp:TextBox ID="Type4_NameArbTextBox" runat="server"></asp:TextBox>
        </div>

        <div class="Div_Row3">
            <asp:Label ID="Label446" runat="server" Text="Type4 NameEng:" 
            AssociatedControlID="Type4_NameEngTextBox"></asp:Label>
            <asp:TextBox ID="Type4_NameEngTextBox" runat="server"></asp:TextBox>
        </div>
    
        <div class="Div_Row3">
            <asp:Label ID="Label448" runat="server" Text="Type4 Status:" 
            AssociatedControlID="Type4_StatusCheckBox"></asp:Label>
            <div class="Div_Row_Inside2">
                 <asp:CheckBox ID="Type4_StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
                 <asp:Label ID="Label447" runat="server" Text="Sorting:" SkinID="Label2"
                 AssociatedControlID="Type4_SortingTextBox"></asp:Label>
                 <asp:TextBox ID="Type4_SortingTextBox" SkinID="TextBox2" runat="server">1</asp:TextBox>
            </div>
            </div>
        <br class="ClearBoth" />
    </div>
    </asp:Panel>

     <div class="Div_Row">
   
        <asp:Label ID="Label453" runat="server" Text="SiteMap Status:"></asp:Label>
        <asp:CheckBox ID="SiteMapCheckBox" runat="server" />
        </div>
      <div class="Div_Row">
        <asp:Label ID="Label452" runat="server" Text="SiteMap Sorting:"></asp:Label>
        <asp:TextBox ID="SiteMapSortingTextBox" runat="server">1</asp:TextBox>

      </div>
    
<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />


