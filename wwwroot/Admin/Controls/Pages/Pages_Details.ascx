.<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pages_Details.ascx.cs"  Inherits="Admin.Admin.Controls.Pages.Pages_Details" %>


<%@ Register src="../MediaUpload/MediaUpload.ascx" tagname="MediaUpload" tagprefix="uc1" %><%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="uc2" %><kfg:collapsiblepanelextender ID="General_CollapsiblePanelExtender"  runat="server"
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
            AssociatedControlID="TitleEngTextBox"></asp:Label>
    <asp:TextBox ID="TitleEngTextBox" runat="server"></asp:TextBox>
     </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="NameArb:" 
            AssociatedControlID="TitleArbTextBox"></asp:Label>
    <asp:TextBox ID="TitleArbTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label2" runat="server" Text="TypeID:" 
            AssociatedControlID="TypeDropDownList"></asp:Label>
    <asp:DropDownList ID="TypeDropDownList" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="TypeDropDownList" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label11" runat="server" Text="Menu Position:" 
            AssociatedControlID="MenuPositionDropDownList"></asp:Label>
    <asp:DropDownList ID="MenuPositionDropDownList" runat="server">
        <asp:ListItem Value="0">None</asp:ListItem>
        <asp:ListItem Value="1">Top</asp:ListItem>
        <asp:ListItem Value="2">Bottom</asp:ListItem>
        <asp:ListItem Value="3">Both</asp:ListItem>
        </asp:DropDownList>
    </div>

      <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status:"></asp:Label>
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    </div>

    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="DescriptionEng:" 
            AssociatedControlID="DescriptionEngTextBox"></asp:Label>
    <asp:TextBox ID="DescriptionEngTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>
    
    <div class="Div_Row">
    <asp:Label ID="Label8" runat="server" Text="DescriptionArb:" 
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
    <uc1:MediaUpload ID="MediaUploadImage" runat="server" />
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
        <uc1:MediaUpload ID="MediaUploadImage2" runat="server" />
    <br />
    </asp:Panel>

     <div class="Div_Row">
         <asp:Label ID="Label6" runat="server" Text="ThumbnailBodyID"></asp:Label>
         <asp:RadioButtonList ID="ThumBodyIDRadioButtonList" runat="server">
             <asp:ListItem Value="1" Selected="True">Thumbnail</asp:ListItem>
             <asp:ListItem Value="2">Thumbnail2</asp:ListItem>
         </asp:RadioButtonList>
         <br class="ClearBoth" />
     </div>
    

    <%--<KFG:CollapsiblePanelExtender ID="Body_CollapsiblePanelExtender"  runat="server"
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
    </KFG:CollapsiblePanelExtender>--%>

    <asp:Panel ID="BodiesHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="BodiesHeaderImage" runat="server" Width="14" Height="14" />
        Body Panel<%--&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="BodiesHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)--%></asp:Panel>
    <asp:Panel ID="BodiesBodyPanel" runat="server" SkinID="LabelHeader">
    
    <div class="Div_Row">
    <asp:Label ID="Label15" runat="server" Text="BodyEng:"></asp:Label>
    <uc2:HTMLEditor ID="BodyEngHTMLEditor" runat="server" />
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label14" runat="server" Text="BodyArb:"></asp:Label>
    <uc2:HTMLEditor ID="BodyArbHTMLEditor" runat="server" />
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
    <asp:Label ID="Label3" runat="server" Text="Template ID:" 
            AssociatedControlID="TemplateIDTextBox"></asp:Label>
    <asp:TextBox ID="TemplateIDTextBox" Text="1" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label5" runat="server" Text="StaticLink:" 
            AssociatedControlID="StaticLinkTextBox"></asp:Label>
    <asp:TextBox ID="StaticLinkTextBox" runat="server"></asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label7" runat="server" Text="Comment Status:" 
            AssociatedControlID="CommentStatusCheckBox"></asp:Label>
    <asp:CheckBox ID="CommentStatusCheckBox" runat="server"></asp:CheckBox>
    </div>
    

    <div class="Div_Row Hide">
    <asp:Label ID="Label13" runat="server" Text="Icon:" 
            AssociatedControlID="IconTextBox"></asp:Label>
    <asp:TextBox ID="IconTextBox" runat="server"></asp:TextBox>
   </div>

   <div class="Div_Row">
    <asp:Label ID="Label17" runat="server" Text="KeywordEng:" 
            AssociatedControlID="KeywordEngTextBox"></asp:Label>
    <asp:TextBox ID="KeywordEngTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>


    <div class="Div_Row">
    <asp:Label ID="Label16" runat="server" Text="KeywordArb:"></asp:Label> 
    <asp:TextBox ID="KeywordArbTextBox" runat="server"  TextMode="MultiLine" SkinID="TextBox_Area" ></asp:TextBox>
    </div>

    
    <div class="Div_Row">
    <asp:Label ID="Label18" runat="server" Text="Count Participate:" 
            AssociatedControlID="CountParticipateTextBox"></asp:Label>
    <asp:TextBox ID="CountParticipateTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label19" runat="server" Text="Count Visit:" 
            AssociatedControlID="CountVisitTextBox"></asp:Label>
    <asp:TextBox ID="CountVisitTextBox" runat="server">0</asp:TextBox>
    </div>

    <div class="Div_Row">
    <asp:Label ID="Label20" runat="server" Text="Count Email:" 
            AssociatedControlID="CountEmailTextBox"></asp:Label>
    <asp:TextBox ID="CountEmailTextBox" runat="server">0</asp:TextBox>
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
