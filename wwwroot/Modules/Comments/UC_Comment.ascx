<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_Comment.ascx.cs" Inherits="Portals_Controls_UC_Comment" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<div class="CommentDiv">
  
    <div class="CommentView">
    <div class="CommentView_Body">
    <asp:GridView ID="CommentGridView" runat="server" AutoGenerateColumns="False"  ShowHeader="false"
        GridLines="None" Width="750px" ondatabound="CommentGridView_DataBound">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                <div class="CommentView_Body_Row">
                    <div class="FloatRight">
                    <asp:Label ID="NumberLabel" CssClass="CommentNumber" runat="server" ></asp:Label>
                   </div> 
                   
                   <div class="FloatRight">
                    <asp:Label ID="NameLabel" runat="server" CssClass="DiscussionLabel" Text='<%# Eval("Comment_SenderName") %>'></asp:Label>
                    </div>
                    <br  class="ClearBoth" />
                    <div class="FloatRight">
                        <asp:Label ID="DateLabel" runat="server" CssClass="CommentDateLabel" 
                            Text='<%# Eval("Date") %>'></asp:Label>
                    </div>
                    <br  class="ClearBoth" />
                    <div class="FloatRight">
                        <asp:Label ID="CommentLabel" runat="server"  CssClass="DiscussionDescription" 
                            Text='<%# Eval("Body") %>'></asp:Label>
                    </div>
                </div>
                </ItemTemplate>
                <HeaderTemplate>

                <div class="Comment_Header_Div">
                    <asp:Label ID="HeaderLabel" runat="server" Text="التعليقات" CssClass="Container_Mid_Header_Label"></asp:Label>
                </div>
                
                </HeaderTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>

    </div>
    
    <asp:UpdatePanel ID="CommentUpdatePanel" runat="server">
    <ContentTemplate>
    
    <div class="CommentInsert FloatRight">
    <div class="Comment_Header_Div">
        <asp:Label ID="CommentHeaderLabel"  CssClass="Container_Mid_Header_Label" Text="Comments Form" runat="server"></asp:Label>
    </div>
    <div class="Comment_Body_Div">
    <div class=" Direction PaddingTop5">
            <asp:Label ID="NameLabel" CssClass="LabelHeader FloatRight" runat="server" Text="Name:" 
                    AssociatedControlID="NameTextBox">
            </asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server" ValidationGroup="comment" CssClass="FloatRight" Width="405px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="NameTextBox" 
            ErrorMessage="Please Enter Your Name" 
            ValidationGroup="comment">*</asp:RequiredFieldValidator>
    </div>
     <br class="ClearBoth" />

    <div class=" Direction ">
    <asp:Label ID="EmailLabel" CssClass="LabelHeader FloatRight" runat="server" Text="Email:" 
            AssociatedControlID="EmailTextBox"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server" ValidationGroup="comment" CssClass="FloatRight" Width="335px"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="EmailTextBox" 
            ErrorMessage="Please Enter Your Email:" 
            ValidationGroup="comment" Display="Dynamic">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="EmailTextBox" 
            ErrorMessage="Please Enter Your Email Correctly" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="comment" CssClass="Vlidation" Display="Dynamic">*</asp:RegularExpressionValidator>
    </div>
     <br class="ClearBoth" />
    <div class="Direction PaddingTop10">
            <div class="FloatRight">
                <asp:Label ID="ContentLabel" CssClass="LabelHeader FloatLeft" runat="server" Text="Comment:" 
                    AssociatedControlID="DetailsTextBox"></asp:Label>
            </div>
            
            <div class="FloatRight">
                <asp:TextBox ID="DetailsTextBox" runat="server" Height="193px" TextMode="MultiLine" 
                Width="380" ValidationGroup="comment"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="DetailsTextBox" 
            ErrorMessage="*" 
            ValidationGroup="comment">*</asp:RequiredFieldValidator> 
            
            </div>
            
        
            
            
        <br class="ClearBoth" />
        
        <div class="DiscussionLinkButtonDiv PaddingTop10 MarginRight200 FloatRight">
                <asp:LinkButton ID="SendLinkButton" runat="server" 
                                onclick="SendLinkButton_Click" 
                                CssClass="CommentLinkButtonImage"  
                                ValidationGroup="comment">
                </asp:LinkButton>
        <br class="ClearBoth" />

        </div>
        
        <asp:Label ID="ResultLabel" CssClass="LabelHeader" runat="server"></asp:Label>
        
          <br class="ClearBoth" />
         <asp:HiddenField ID="IDHiddenField" runat="server" />
         <asp:HiddenField ID="SourceHiddenField" runat="server" />
         <asp:HiddenField ID="TitleHiddenField" runat="server" />

    </div>
    </div>
    </div>
    
    </ContentTemplate>
    </asp:UpdatePanel>
    <br class="ClearBoth" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate >
            <asp:Image ID="ProgressImage" ImageUrl="~/images/CommentLoading.gif" runat="server" />
        </ProgressTemplate>
        </asp:UpdateProgress>
</div>