<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UC_NewsBar.ascx.cs" Inherits="Portals_Controls_UC_NewsBar" %>
<div class="NewsBar_Div">
     
    <div class="NewsBar_Content FloatLeft" >
    
        <div class="NewsBar_Controls FloatLeft">
            <asp:Image ID="Image3" onclick="document.all.MarqueeNews.direction='left';document.all.MarqueeNews.scrollAmount=4" ImageUrl="~/images/NewsBar_ControlLeft.gif" runat="server"/>
            <asp:Image ID="Image2" onclick="document.all.MarqueeNews.scrollAmount=0" ImageUrl="~/images/NewsBar_Pause.gif" runat="server"/> 
            <asp:Image ID="Image1" onclick="document.all.MarqueeNews.direction='right';document.all.MarqueeNews.scrollAmount=4" ImageUrl="~/images/NewsBar_ControlRight.gif" runat="server" />  
        </div>

         <div class="NewsBar_Marquee FloatRight">
            <marquee id="MarqueeNews" direction="right"  loop="infinite" scrollamount="4" style="width:100%">
                    <asp:Literal ID="NewsLabel" runat="server" ></asp:Literal>
            </marquee>
                            
        </div>
    
    </div>
 </div>