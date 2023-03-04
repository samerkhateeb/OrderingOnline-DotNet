<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_VotingQuestions.ascx.cs" Inherits="Portals_Controls_UC_VotingQuestions" %>

<asp:UpdateProgress ID="VotingUpdateProgress" runat="server">
<ProgressTemplate>
    <asp:Image ID="ImageLoading" runat="server" ImageUrl="~/images/CommentLoading.gif" />
</ProgressTemplate>
</asp:UpdateProgress>

<asp:UpdatePanel ID="VotingUpdatePanel" runat="server">
    <ContentTemplate> 
        <div class="Voting_Div">
        
        <div class="Container_Right_Header_Div">
            <asp:Label ID="ParentHeaderLabel" runat="server" CssClass="Container_Mid_Header_Label" ></asp:Label>
        </div>
        <div class="Voting_Body">
            <asp:GridView ID="VotingParentGridView" runat="server"
                          AutoGenerateColumns="False" 
                          DataKeyNames="VQuestion_ID" 
                          onrowcommand="VotingParentGridView_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                        
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:RequiredFieldValidator ID="VotingRequiredFieldValidator" runat="server" 
                                ErrorMessage="*" ForeColor="" 
                                ControlToValidate="VotingRadioButtonList" >
                            </asp:RequiredFieldValidator>

                            <asp:Panel ID="VotingQuestionsPanel" runat="server">
                               <asp:Label ID="HeaderLabel" runat="server" CssClass="Container_Mid_Body_LabelTitle FloatRight"></asp:Label>
                                <br class="ClearBoth" />
                                    <asp:RadioButtonList ID="VotingRadioButtonList" runat="server" CssClass="Voting_Body_ReadioList" >
                                    </asp:RadioButtonList>

                                <div class="MarginCenter">
                                    <asp:LinkButton ID="SubmitLinkButton" CssClass="Voting_SubmitButton FloatRight"  runat="server">
                                    </asp:LinkButton>

                                    <asp:LinkButton ID="ResultLinkButton" CssClass="Voting_ResultButton FloatRight" CommandName="result" runat="server">
                                    </asp:LinkButton>
                                </div>

                            </asp:Panel>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </div>
        </div>
    </ContentTemplate>
   
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="VotingParentGridView" EventName="RowCommand" />
    </Triggers>
</asp:UpdatePanel>


