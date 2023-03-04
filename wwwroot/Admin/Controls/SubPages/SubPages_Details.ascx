<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SubPages_Details.ascx.cs"
    Inherits="Admin.Admin.Controls.SubPages.SubPages_Details" %>
<%@ Register Src="../MediaUpload/MediaUpload.ascx" TagName="MediaUpload" TagPrefix="uc1" %>
<%@ Register Src="../HTMLEditor/HTMLEditor.ascx" TagName="HTMLEditor" TagPrefix="uc2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<kfg:collapsiblepanelextender id="General_CollapsiblePanelExtender" runat="server"
    targetcontrolid="GeneralBodyPanel" textlabelid="GeneralHeaderLabel" collapsecontrolid="GeneralHeaderPanel"
    expandcontrolid="GeneralHeaderPanel" imagecontrolid="GeneralHeaderImage" collapsedsize="0"
    collapsedtext="Show Details" expandedsize="390" expandedtext="Hide Details" suppresspostback="True"
    collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif" expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="GeneralHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="GeneralHeaderImage" runat="server" Width="14" Height="14" />
    General Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="GeneralHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="GeneralBodyPanel" runat="server" SkinID="LabelHeader">
    <div class="Div_Row">
        <asp:Label ID="Label7" runat="server" Text="NameEng:" AssociatedControlID="NameEngTextBox"></asp:Label>
        <asp:TextBox ID="NameEngTextBox" runat="server"></asp:TextBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label6" runat="server" Text="NameArb:" AssociatedControlID="NameArbTextBox"></asp:Label>
        <asp:TextBox ID="NameArbTextBox" runat="server"></asp:TextBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label1" runat="server" Text="TypeID:" AssociatedControlID="TypeIDDropDownList"></asp:Label>
        <asp:DropDownList ID="TypeIDDropDownList" runat="server">
        </asp:DropDownList>
    </div>
    <div class="Div_Row Hide">
        <asp:Label ID="Label4" runat="server" Text="TemplateID:" AssociatedControlID="TemplateIDTextBox"></asp:Label>
        <asp:TextBox ID="TemplateIDTextBox" runat="server">1</asp:TextBox>
    </div>
    <div class="Div_Row Hide">
        <asp:Label ID="Label5" runat="server" Text="ParentID:" AssociatedControlID="ParentIDTextBox"></asp:Label>
        <asp:TextBox ID="ParentIDTextBox" runat="server">1</asp:TextBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label33" runat="server" Text="MenuPosition:" AssociatedControlID="MenuPositionDropDownList"></asp:Label>
        <asp:DropDownList ID="MenuPositionDropDownList" runat="server">
            <asp:ListItem Value="0">None</asp:ListItem>
            <asp:ListItem Value="1">Top</asp:ListItem>
            <asp:ListItem Value="2">Both</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label24" runat="server" Text="Status:" AssociatedControlID="StatusCheckBox"></asp:Label>
        <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="true"></asp:CheckBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label27" runat="server" Text="Sorting:" AssociatedControlID="SortingTextBox"></asp:Label>
        <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label9" runat="server" Text="DescriptionEng:" AssociatedControlID="DescriptionEngTextBox"></asp:Label>
        <asp:TextBox ID="DescriptionEngTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area"></asp:TextBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label8" runat="server" Text="DescriptionArb:" AssociatedControlID="DescriptionArbTextBox"></asp:Label>
        <asp:TextBox ID="DescriptionArbTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area"></asp:TextBox>
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="ThumbnailPanel_CollapsiblePanelExtender" runat="server"
    targetcontrolid="ThumbnailBodyPanel" textlabelid="ThumbnailHeaderLabel" collapsecontrolid="ThumbnailHeaderPanel"
    expandcontrolid="ThumbnailHeaderPanel" imagecontrolid="ThumbnailHeaderImage"
    collapsedsize="0" collapsedtext="Show Details" collapsed="false" expandedsize="0"
    expandedtext="Hide Details" suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
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
    targetcontrolid="Thumbnail2BodyPanel" textlabelid="Thumbnail2HeaderLabel" collapsecontrolid="Thumbnail2HeaderPanel"
    expandcontrolid="Thumbnail2HeaderPanel" imagecontrolid="Thumbnail2HeaderImage"
    collapsedsize="0" collapsedtext="Show Details" expandedsize="0" expandedtext="Hide Details"
    suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
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
         <asp:Label ID="Label25" runat="server" Text="ThumbnailBodyID"></asp:Label>
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
<asp:Panel ID="BodiesBodyPanel" runat="server" SkinID="LabelHeaderBody">
    <div class="Div_Row">
        <asp:Label ID="Label11" runat="server" Text="BodyEng:"></asp:Label>
        <uc2:HTMLEditor ID="BodyEngHTMLEditor" runat="server" />
        <br class="ClearBoth" />
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label10" runat="server" Text="BodyArb:"></asp:Label>
        <uc2:HTMLEditor ID="BodyArbHTMLEditor" runat="server" />
        <br class="ClearBoth" />
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="StatuslPanel_CollapsiblePanelExtender" runat="server"
    targetcontrolid="StatusBodyPanel" textlabelid="StatusHeaderLabel" collapsecontrolid="StatusHeaderPanel"
    expandcontrolid="StatusHeaderPanel" imagecontrolid="StatusHeaderImage" collapsedsize="0"
    collapsedtext="Show Details" collapsed="true" expandedsize="190" expandedtext="Hide Details"
    suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="StatusHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="StatusHeaderImage" runat="server" Width="14" Height="14" />
    Status Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="StatusHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="StatusBodyPanel" runat="server" SkinID="LabelHeader">
    <div>
        <div class="Div_Row">
            <asp:Label ID="Label21" runat="server" Text="Hot News:" AssociatedControlID="HotNewsStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="HotNewsStatusCheckBox" runat="server"></asp:CheckBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label22" runat="server" Text="Last News:" AssociatedControlID="LastNewsStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="LastNewsStatusCheckBox" runat="server"></asp:CheckBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label23" runat="server" Text="Discussions:" AssociatedControlID="DiscussionsStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="DiscussionsStatusCheckBox" runat="server"></asp:CheckBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label26" runat="server" Text="Comment:" AssociatedControlID="CommentStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="CommentStatusCheckBox" runat="server"></asp:CheckBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label40" runat="server" Text="New Icon:" AssociatedControlID="NewIconStatusCheckBox"></asp:Label>
            <asp:CheckBox ID="NewIconStatusCheckBox" runat="server"></asp:CheckBox>
        </div>
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="MediaFile_CollapsiblePanelExtender" runat="server"
    targetcontrolid="MediaFileBodyPanel" textlabelid="MediaFileHeaderLabel" collapsecontrolid="MediaFileHeaderPanel"
    expandcontrolid="MediaFileHeaderPanel" imagecontrolid="MediaFileHeaderImage"
    collapsedsize="0" collapsedtext="Show Details" collapsed="True" expandedsize="0"
    expandedtext="Hide Details" suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="MediaFileHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="MediaFileHeaderImage" runat="server" Width="14" Height="14" />
    MediaFile Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="MediaFileHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="MediaFileBodyPanel" runat="server" SkinID="LabelHeader">
    <div class="Div_Row">
        <asp:Label ID="Label14" runat="server" Text="MediaFile:"></asp:Label>
        <uc1:MediaUpload ID="Media" runat="server" />
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="Advance_CollapsiblePanelExtender" runat="server"
    targetcontrolid="AdvanceBodyPanel" textlabelid="AdvanceHeaderLabel" collapsecontrolid="AdvanceHeaderPanel"
    expandcontrolid="AdvanceHeaderPanel" imagecontrolid="AdvanceHeaderImage" collapsedsize="0"
    collapsedtext="Show Details" collapsed="true" expandedsize="430" expandedtext="Hide Details"
    suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="AdvanceHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="AdvanceHeaderImage" runat="server" Width="14" Height="14" />
    Advance Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="AdvanceHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="AdvanceBodyPanel" runat="server" SkinID="LabelHeader">
    <div>
        <div class="Div_Row">
            <asp:Label ID="Label2" runat="server" Text="Parent:" AssociatedControlID="CATDropDownList"></asp:Label>
            <asp:DropDownList ID="CATDropDownList" runat="server">
            </asp:DropDownList>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label3" runat="server" Text="GroupID:" AssociatedControlID="GroupIDDropDownList"></asp:Label>
            <asp:DropDownList ID="GroupIDDropDownList" runat="server">
            </asp:DropDownList>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label12" runat="server" Text="StaticLink:" AssociatedControlID="StaticLinkTextBox"></asp:Label>
            <asp:TextBox ID="StaticLinkTextBox" runat="server"></asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label16" runat="server" Text="KeywordEng:" AssociatedControlID="KeywordEngTextBox"></asp:Label>
            <asp:TextBox ID="KeywordEngTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area"></asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label15" runat="server" Text="KeywordArb:" AssociatedControlID="KeywordArbTextBox"></asp:Label>
            <asp:TextBox ID="KeywordArbTextBox" runat="server" TextMode="MultiLine" SkinID="TextBox_Area"></asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label17" runat="server" Text="CountVisit:" AssociatedControlID="CountVisitTextBox"></asp:Label>
            <asp:TextBox ID="CountVisitTextBox" runat="server">0</asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label18" runat="server" Text="CountPrint:" AssociatedControlID="CountPrintTextBox"></asp:Label>
            <asp:TextBox ID="CountPrintTextBox" runat="server">0</asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label19" runat="server" Text="CountEmail:" AssociatedControlID="CountEmailTextBox"></asp:Label>
            <asp:TextBox ID="CountEmailTextBox" runat="server">0</asp:TextBox>
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label20" runat="server" Text="CountParticipate:" AssociatedControlID="CountParticipateTextBox"></asp:Label>
            <asp:TextBox ID="CountParticipateTextBox" runat="server">0</asp:TextBox>
        </div>
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="Target_CollapsiblePanelExtender" runat="server"
    targetcontrolid="ModifierBodyPanel" textlabelid="ModifierHeaderLabel" collapsecontrolid="ModifierHeaderPanel"
    expandcontrolid="ModifierHeaderPanel" imagecontrolid="ModifierHeaderImage" collapsedsize="0"
    collapsedtext="Show Details" collapsed="true" expandedsize="110" expandedtext="Hide Details"
    suppresspostback="True" collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
    expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="ModifierHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="ModifierHeaderImage" runat="server" Width="14" Height="14" />
    Modifier Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="ModifierHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="ModifierBodyPanel" runat="server" SkinID="LabelHeader">
    <div class="Div_Row">
        <asp:Label ID="Label71" runat="server" Text="Modifier Status:" AssociatedControlID="ModifierCheckBox"></asp:Label>
        <asp:CheckBox ID="ModifierCheckBox" runat="server"></asp:CheckBox>
    </div>
    <div class="Div_Row">
        <asp:Label ID="Label62" runat="server" Text="Modifier ID:" AssociatedControlID="ModifierDropdownlist"></asp:Label>
        <asp:DropDownList ID="ModifierDropdownlist" runat="server">
        </asp:DropDownList>
    </div>
</asp:Panel>
<kfg:collapsiblepanelextender id="Type_CollapsiblePanelExtender" runat="server" targetcontrolid="TypeBodyPanel"
    textlabelid="TypeHeaderLabel" collapsecontrolid="TypeHeaderPanel" expandcontrolid="TypeHeaderPanel"
    imagecontrolid="TypeHeaderImage" collapsedsize="0" collapsedtext="Show Details"
    collapsed="true" expandedsize="470" expandedtext="Hide Details" suppresspostback="True"
    collapsedimage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif" expandedimage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif">
    </kfg:collapsiblepanelextender>
<asp:Panel ID="TypeHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
    <asp:Image ID="TypeHeaderImage" runat="server" Width="14" Height="14" />
    Type Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="TypeHeaderLabel" SkinID="Label2"
        runat="server"></asp:Label>)
</asp:Panel>
<asp:Panel ID="TypeBodyPanel" runat="server" SkinID="LabelHeader">
    <div>
        <div class="Div_Row">
            <asp:Label ID="Label36" runat="server" Text="Type1 :" AssociatedControlID="Type1_HD_StatusCheckBox"></asp:Label>
            <asp:Label ID="Label28" runat="server" Text="Price:" SkinID="Lable2" AssociatedControlID="Type1_PriceTextBox"></asp:Label>
            <asp:TextBox ID="Type1_PriceTextBox" SkinID="TextBox2" runat="server"></asp:TextBox>
            <div class="Div_Row_Inside">
                <asp:Label ID="Label340" runat="server" Text="HD:" SkinID="Label2" AssociatedControlID="Type1_HD_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type1_HD_StatusCheckBox" runat="server"></asp:CheckBox>
                <asp:Label ID="Label34" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type1_HD_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type1_HD_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside">
                <asp:Label ID="Label37" runat="server" Text="PU:" SkinID="Label2" AssociatedControlID="Type1_PU_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type1_PU_StatusCheckBox" SkinID="TextBox2" runat="server"></asp:CheckBox>
                <asp:Label ID="Label35" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type1_PU_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type1_PU_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside3">
                <asp:Label ID="Label451" runat="server" Text="Name:" SkinID="Label2"></asp:Label>
                <asp:TextBox ID="CustomName1TextBox" runat="server" SkinID="TextBox3"></asp:TextBox>
                <div class="FloatRight">
                    <asp:RadioButtonList ID="Type1RadioButtonList" runat="server" SkinID="Label2" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="0">Category</asp:ListItem>
                        <asp:ListItem Value="1">Custom</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <br class="ClearBoth" />
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label236" runat="server" Text="Type2 :" AssociatedControlID="Type2_HD_StatusCheckBox"></asp:Label>
            <asp:Label ID="Label128" runat="server" Text="Price:" SkinID="Label2" AssociatedControlID="Type2_PriceTextBox"></asp:Label>
            <asp:TextBox ID="Type2_PriceTextBox" SkinID="TextBox2" runat="server"></asp:TextBox>
            <div class="Div_Row_Inside">
                <asp:Label ID="Label240" runat="server" Text="HD:" SkinID="Label2" AssociatedControlID="Type2_HD_StatusCheckBox"
                    Style="direction: ltr"></asp:Label>
                <asp:CheckBox ID="Type2_HD_StatusCheckBox" runat="server"></asp:CheckBox>
                <asp:Label ID="Label234" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type2_HD_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type2_HD_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside">
                <asp:Label ID="Label237" runat="server" Text="PU:" SkinID="Label2" AssociatedControlID="Type2_PU_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type2_PU_StatusCheckBox" SkinID="TextBox2" runat="server"></asp:CheckBox>
                <asp:Label ID="Label235" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type2_PU_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type2_PU_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside3">
                <asp:Label ID="Label13" runat="server" Text="Name:" SkinID="Label2"></asp:Label>
                <asp:TextBox ID="CustomName2TextBox" runat="server" SkinID="TextBox3"></asp:TextBox>
                <div class="FloatRight">
                    <asp:RadioButtonList ID="Type2RadioButtonList" runat="server" SkinID="Label2" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="0">Category</asp:ListItem>
                        <asp:ListItem Value="1">Custom</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <br class="ClearBoth" />
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label43" runat="server" Text="Type3 :" AssociatedControlID="Type3_HD_StatusCheckBox"></asp:Label>
            <asp:Label ID="Label44" runat="server" Text="Price:" SkinID="Label2" AssociatedControlID="Type3_PriceTextBox"></asp:Label>
            <asp:TextBox ID="Type3_PriceTextBox" SkinID="TextBox2" runat="server"></asp:TextBox>
            <div class="Div_Row_Inside">
                <asp:Label ID="Label45" runat="server" Text="HD:" SkinID="Label2" AssociatedControlID="Type3_HD_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type3_HD_StatusCheckBox" runat="server"></asp:CheckBox>
                <asp:Label ID="Label46" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type3_HD_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type3_HD_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside">
                <asp:Label ID="Label47" runat="server" Text="PU:" SkinID="Label2" AssociatedControlID="Type3_PU_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type3_PU_StatusCheckBox" SkinID="TextBox2" runat="server"></asp:CheckBox>
                <asp:Label ID="Label448" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type3_PU_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type3_PU_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside3">
                <asp:Label ID="Label38" runat="server" Text="Name:" SkinID="Label2"></asp:Label>
                <asp:TextBox ID="CustomName3TextBox" runat="server" SkinID="TextBox3"></asp:TextBox>
                <div class="FloatRight">
                    <asp:RadioButtonList ID="Type3RadioButtonList" runat="server" SkinID="Label2" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="0">Category</asp:ListItem>
                        <asp:ListItem Value="1">Custom</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <br class="ClearBoth" />
        </div>
        <div class="Div_Row">
            <asp:Label ID="Label50" runat="server" Text="Type4 :" AssociatedControlID="Type4_HD_StatusCheckBox"></asp:Label>
            <asp:Label ID="Label51" runat="server" Text="Price:" SkinID="Label2" AssociatedControlID="Type4_PriceTextBox"></asp:Label>
            <asp:TextBox ID="Type4_PriceTextBox" SkinID="TextBox2" runat="server"></asp:TextBox>
            <div class="Div_Row_Inside">
                <asp:Label ID="Label251" runat="server" Text="HD:" SkinID="Label2" AssociatedControlID="Type4_HD_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type4_HD_StatusCheckBox" runat="server"></asp:CheckBox>
                <asp:Label ID="Label52" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type4_HD_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type4_HD_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside">
                <asp:Label ID="Label53" runat="server" Text="PU:" SkinID="Label2" AssociatedControlID="Type4_PU_StatusCheckBox"></asp:Label>
                <asp:CheckBox ID="Type4_PU_StatusCheckBox" SkinID="TextBox2" runat="server"></asp:CheckBox>
                <asp:Label ID="Label54" runat="server" Text="Code:" SkinID="Label2" AssociatedControlID="Type4_PU_CodeTextBox"></asp:Label>
                <asp:TextBox ID="Type4_PU_CodeTextBox" SkinID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br class="ClearBoth" />
            <div class="Div_Row_Inside3">
                <asp:Label ID="Label39" runat="server" Text="Name:" SkinID="Label2"></asp:Label>
                <asp:TextBox ID="CustomName4TextBox" runat="server" SkinID="TextBox3"></asp:TextBox>
                <div class="FloatRight">
                    <asp:RadioButtonList ID="Type4RadioButtonList" runat="server" SkinID="Label2" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="0">Category</asp:ListItem>
                        <asp:ListItem Value="1">Custom</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <br class="ClearBoth" />
        </div>
        <br class="ClearBoth" />
    </div>
    </div>
</asp:Panel>
<div class="Div_Row">
    <asp:Label ID="Label449" runat="server" Text="RuleID:"></asp:Label>
    <asp:CheckBoxList ID="RuleIDCheckBoxList" runat="server">
    </asp:CheckBoxList>
    <br />
</div>
<div class="Div_Row">
    <asp:Label ID="Label450" runat="server" Text="Special User:"></asp:Label>
    <asp:TextBox ID="SpecialUserTextBox" runat="server"></asp:TextBox>
    <br />
</div>
<div class="Div_Row">
    <asp:Label ID="Label453" runat="server" Text="SiteMap Status:"></asp:Label>
    <asp:CheckBox ID="SiteMapCheckBox" runat="server" />
</div>
<div class="Div_Row">
    <asp:Label ID="Label452" runat="server" Text="SiteMap Sorting:"></asp:Label>
    <asp:TextBox ID="SiteMapSortingTextBox" runat="server">1</asp:TextBox>
</div>
<div class="Div_Row">
    <asp:Label ID="Label41" runat="server" Text="Promotion Status:"></asp:Label>
    <asp:CheckBox ID="PromotionCheckBox" runat="server" />
</div>
<div class="Div_Row">
    <asp:Label ID="Label42" runat="server" Text="Schedule Status:"></asp:Label>
    <asp:CheckBox ID="ScheduleStatusCheckBox" runat="server" />
</div>
<div class="Div_Row">
    <asp:Label ID="Label48" runat="server" Text="Schedule From:"></asp:Label>
    <asp:TextBox ID="ScheduleFromTextBox" runat="server"></asp:TextBox>
    <asp:CalendarExtender ID="ScheduleFromTextBox_CalendarExtender" runat="server" TargetControlID="ScheduleFromTextBox">
    </asp:CalendarExtender>
    <br />
</div>
<div class="Div_Row">
    <asp:Label ID="Label49" runat="server" Text="Schedule To:"></asp:Label>
    <asp:TextBox ID="ScheduleToTextBox" runat="server"></asp:TextBox>
    <asp:CalendarExtender ID="ScheduleToTextBox_CalendarExtender" runat="server" TargetControlID="ScheduleToTextBox">
    </asp:CalendarExtender>
    <br />
</div>
<asp:Button ID="OperationButton" runat="server" OnClick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" OnClick="CancelLinkButton_Click" Text="Cancel" />
