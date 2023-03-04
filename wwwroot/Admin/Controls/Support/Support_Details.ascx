<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Support_Details.ascx.cs" Inherits="Admin.Admin.Controls.Support.Support_Details" %>



<%@ Register src="Support_Forms.ascx" tagname="Support_Forms" tagprefix="uc1" %>


<kfg:collapsiblepanelextender ID="Comment_CollapsiblePanelExtender"  runat="server"
        TargetControlID="CommentBodyPanel" 
        TextLabelID="CommentHeaderLabel" 
        CollapseControlID="CommentHeaderPanel" 
        ExpandControlID="CommentHeaderPanel" 
        ImageControlID="CommentHeaderImage"
        CollapsedSize="0" 
        CollapsedText="Show Details" 
        ExpandedSize="0" 
        ExpandedText="Hide Details" 
        SuppressPostBack="True" 
        CollapsedImage="/App_Themes/AdminSkin/CssImages/ExpandIcon.gif"
        ExpandedImage="/App_Themes/AdminSkin/CssImages/CollapseIcon.gif"
        >
    </kfg:collapsiblepanelextender>

    <asp:Panel ID="CommentHeaderPanel" runat="server" SkinID="PanelHeaderCollaps">
        <asp:Image ID="CommentHeaderImage" runat="server" Width="14" Height="14" />
        Comments Panel&nbsp;&nbsp;&nbsp;&nbsp;(<asp:Label ID="CommentHeaderLabel" SkinID="Label2" runat="server"></asp:Label>)
    </asp:Panel>
    <asp:Panel ID="CommentBodyPanel" runat="server" SkinID="LabelHeader">

<asp:GridView ID="ManagerGridView" DataKeyNames="Support_ID" runat="server" AutoGenerateColumns="False" 
    ShowHeader="False">
    <Columns>
        <asp:TemplateField ShowHeader="False">
            <EditItemTemplate>
                <span ID="ctl00_ManagerGridView_Label1_1">Databound</span>
            </EditItemTemplate>
            <FooterTemplate>
                <span ID="ctl00_ManagerGridView_Label1_3">Databound</span>
            </FooterTemplate>
            <HeaderTemplate>
                <span ID="ctl00_ManagerGridView_Label1_2">Databound</span>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    Text='<%# String.Format("Subject: {0}", Eval("Support_Subject")) %>'></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" 
                    Text='<%# String.Format("Email: {0}",  Eval("Support_Email")) %>'></asp:Label>
               
                <asp:Label ID="CategoryLabel" runat="server" Visible="false"
                    Text='<%# String.Format("Category: {0}",Eval("Support_Category")) %>'></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" 
                    Text='<%# String.Format("Comment: {0}", Eval("Support_Comment")) %>'></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" 
                    Text='<%# String.Format("Date: {0}", Eval("Support_Date")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<br />
</asp:Panel>

<uc1:Support_Forms ID="Support_Forms1" runat="server" />





