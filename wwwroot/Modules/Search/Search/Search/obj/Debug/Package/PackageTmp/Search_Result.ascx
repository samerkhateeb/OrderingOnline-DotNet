<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search_Result.ascx.cs" Inherits="Search.Search_Result" %>

<%@ Import Namespace="KFGCMS.BLL" %>
<div class="PageHeaderDiv FloatRight">
    <asp:Label ID="SearchLabel" CssClass="Container_Mid_Header_Label" runat="server"></asp:Label>
</div>
<div class="PageBody">
<asp:GridView ID="ResultGridView" runat="server" AutoGenerateColumns="False" 
    GridLines="None" ShowHeader="False" DataKeyNames="ID" 
        onrowcommand="ResultGridView_RowCommand" CssClass="FloatRight">
    <Columns>
        <asp:TemplateField>
            <EditItemTemplate>
            </EditItemTemplate>
            <ItemTemplate>
            <div class="">
                    <asp:HyperLink ID="LeftHyperLink" CssClass="ItemLinkButton"  runat="server" 
                                        NavigateUrl='<%# Pages_BLL.GenerateUrl(Eval("ID"),String.Format("{0}","SubPage"),Eval("Type"),Eval("StaticLink")) %>' 
                                        Text='<%# Eval("Title") %>'>
                    </asp:HyperLink>
                                        
                    <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' CssClass="DescriptionLabel FloatRight" ></asp:Label>
                               
                    <br class="ClearBoth" />
                <asp:Label  ID="DescriptionLabel" CssClass="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>'>
                </asp:Label>

           <br class="ClearBoth" />
           <br class="ClearBoth" />
           <hr class="" />
           
           </div>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</div>

