<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Banners_Details.ascx.cs" Inherits="Admin.Admin.Banners.Banners.Banners_Details" %>



<%@ Register src="../HTMLEditor/HTMLEditor.ascx" tagname="HTMLEditor" tagprefix="KFG" %>



<div class="Div_Row">
        <asp:Label ID="Label2" runat="server" Text="Name :" 
            AssociatedControlID="NameTextBox"></asp:Label>
   
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
   </div>

           
        <div class="Div_Row">
    <asp:Label ID="Label3" runat="server" Text="Top :" 
            AssociatedControlID="TopCheckBox"></asp:Label>
        <asp:CheckBox ID="TopCheckBox" runat="server"></asp:CheckBox>
     
   </div>

    
    <div class="Div_Row">
    <asp:Label ID="Label1" runat="server" Text="Left :" 
            AssociatedControlID="LeftCheckBox"></asp:Label>
    
    <asp:CheckBox ID="LeftCheckBox" runat="server"></asp:CheckBox>
     
</div>

    
    <div class="Div_Row">
    <asp:Label ID="Label4" runat="server" Text="Mid :" 
            AssociatedControlID="MidCheckBox"></asp:Label>
       <asp:CheckBox ID="MidCheckBox" runat="server"></asp:CheckBox>
     
    </div>

   
    <div class="Div_Row">
       <asp:Label ID="Label5" runat="server" Text="Subpage :" 
            AssociatedControlID="SubepageCheckBox"></asp:Label>
    
    <asp:CheckBox ID="SubepageCheckBox" runat="server"></asp:CheckBox>
     
  </div>

  
        
    <div class="Div_Row">
        <asp:Label ID="Labe8" runat="server" Text="Status :" AssociatedControlID="StatusCheckBox"></asp:Label>
    
    <asp:CheckBox ID="StatusCheckBox" runat="server" Checked="True"></asp:CheckBox>
    
</div>

<div class="Div_Row">
            <asp:Label ID="Label9" runat="server" Text="Sorting :" AssociatedControlID="SortingTextBox"></asp:Label>
    
    <asp:TextBox ID="SortingTextBox" runat="server">1</asp:TextBox>
    
</div>

<div class="Div_Row">
  
    <asp:Label ID="Label6" runat="server" Text="Mid Bottom :" 
            AssociatedControlID="MidBottomCheckBox"></asp:Label>
   
    <asp:CheckBox ID="MidBottomCheckBox" runat="server"></asp:CheckBox>
     
</div>

   
    <div class="Div_Row">
  
    <asp:Label ID="Label7" runat="server" Text="Left Bottom :" 
            AssociatedControlID="LeftBottomCheckBox"></asp:Label>
    
    <asp:CheckBox ID="LeftBottomCheckBox" runat="server"></asp:CheckBox>
   
</div>

 <div class="Div_Row">
    <asp:Label ID="Label10" runat="server" Text="BodyEng:" 
            AssociatedControlID="HTMLEditorEnglish"></asp:Label>
     <%--<asp:TextBox ID="BodyEngTextBox" runat="server"></asp:TextBox>--%>

        <KFG:HTMLEditor ID="HTMLEditorEnglish" runat="server" />
</div>

   
   <div class="Div_Row">
       <asp:Label ID="Label8" runat="server" Text="BodyArb:" 
            AssociatedControlID="HTMLEditorArabic"></asp:Label>
    
    <%--<asp:TextBox ID="BodyArbTextBox" runat="server"></asp:TextBox>--%>
     
        <KFG:HTMLEditor ID="HTMLEditorArabic" runat="server" />
     
</div>

   

<asp:Button ID="OperationButton" runat="server" 
    onclick="OperationLinkButton_Click" />
<asp:Button ID="CancelButton" runat="server" onclick="CancelLinkButton_Click" 
    Text="Cancel" />

