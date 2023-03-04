<%@ Control Language="C#" AutoEventWireup="true" Inherits="HotNews" Codebehind="HotNews.ascx.cs" %>
<%--<%@ Import Namespace="KFGCMS.BLL" %>--%>
<script src="/Modules/HotNews/scripts/HotNews.js" type="text/javascript"></script>
<link href="/Modules/HotNews/css/StyleSheet.css" rel="stylesheet" type="text/css" />


 <div class="HotNews_Div">
    <%--<asp:Literal ID="HeaderLiteral" runat="server"></asp:Literal>--%>
        
<div class="HotNewsContent">

	

<UL class="" id="promoCarousel">
          <asp:Literal ID="ItemLiteral" runat="server"></asp:Literal>
</UL>
<A id="carouselNext" href="javascript:void(0)">« Next</A>

    <A id="carouselPrev" href="javascript:void(0)">Pre »</A>
<%--<div class="carouselControlsWrapper">

      <UL class=carouselControls>
          <asp:Literal ID="ULLiteral" runat="server"></asp:Literal>
      </UL>
      

      </div>--%>

</div>

</div>
