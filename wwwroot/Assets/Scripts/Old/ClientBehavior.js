

var printTitle= "موقع خطابة",
    printSource = "المصدر: موقع خطابة",
    printWebsite = "www.khattabeh.com",
    printStyle = "<style>.BodyPrint{text-align:right;direction:rtl;background-color:#fff;}.LabelTitle{font-family:arial,serif;font-weight:bold;font-size:16px;}</style>",
    printLogoPath = "/Images/LogoAlone.gif",
    emailWindowPropery = "menubar=0,resizable=0,width=500,height=500",
    bookMarkTitle = "موقع خطابة",
    bookMaskrUrl = "http://www.khattabeh.com";


 //setTimeout(' document.location=document.location' ,1200000);

function GetStartPage ()
{
   // window.history.length = 1;
    location.href="Portals/default/";
//    location.replace("ajax.aspx");
    
}
    function EmailSendError (Message)
    {
        alert(Message);
    }
    function RequestSubPage(sid)
    {
        $get('ctl00_UpdateProgressLoad').style.display = "none";
        $get('ctl00_UpdateProgressLoad').style.display = "inline";
        PageMethods.ChangeSubValue(sid, OnSucceeded, OnFail);
    }
    
    function RequestPage(id)
    {
        $get('ctl00_UpdateProgressLoad').style.display = "none";
        $get('ctl00_UpdateProgressLoad').style.display = "inline";
        PageMethods.ChangeValue(id, OnSucceeded, OnFail);
    }
    
    function OnSucceeded(result, userContext, methodName)
    {
        $get('ctl00_UpdateProgressLoad').style.display = "none";
        document.getElementById('DivAjax').innerHTML = "<span class='Adirection DivSpanAjax'>"+result+"</span>";
     //  $get('ctl00_CPH_PanelDefault').style.display = "none";
    }
    
    function OnFail (error,userContext, methodName)
    {
         $get('ctl00_UpdateProgressLoad').style.display = "none";
        //$get('Label1').innerHTML = error;
    }
    
    function _hbLink(type,id)
    {
       parent.document.location = type +'.apx'+'id='+id;
    }
    
    
     function ShokWave_Generation ()
    {
       
       var so = new SWFObject("FLA/Banner.swf", "BannderFlash", "860", "218");
       so.useExpressInstall('FLA/expressinstall.swf');
       so.addParam("quality", "high");
       so.addParam("wmode", "transparent");
       so.addParam("menu", "false");
       so.write("Flash");
    }
    
    
    function PrintPage()
{ 
		var disp_setting="toolbar=yes,location=no,directories=yes,menubar=yes,"; 
		    disp_setting+="scrollbars=yes,width=650, height=600, left=100, top=25"; 
		var content_vlue = document.getElementById("print_content").innerHTML; 
	
		var docprint=window.open("","",disp_setting); 
			docprint.document.open(); 
			docprint.document.write('<html><head><title>' + printTitle + '</title>' + printStyle); 
			docprint.document.write('</head><body onLoad="self.print();window.close();"><div class="BodyPrint"><div class=LabelTitle>'+printSource+'</div>');          
			docprint.document.write('<div class="PrintCopyRight"><img src="'+printLogoPath+'" /><br /> <BR /> <div class=LabelTitle>'+printWebsite+'</div></div>');
			docprint.document.write(content_vlue);
			  

			docprint.document.write('</div></body></html>'); 
			docprint.document.close(); 
			docprint.focus(); 
}

function SendEmail ()
{
    window.open('../Email/?url='+window.location,'EmailWindow',emailWindowPropery);
}


function CloseWindow()
{
   // setTimeout('window.top.window.top.window.top.window.opener = self; window.top.window.top.window.top.window.top.close();',2000);
    setTimeout("window.open('','_self','');window.close();",2000);
}


function MediaClick()
{
}


function setHome()
                {
                   document.body.style.behavior='url(#default#homepage)';
                   document.body.setHomePage(window.location.href);
                }
                
                
function addbookmark()
{
    if (document.all)
        window.external.addFavorite(bookMaskrUrl,bookMarkTitle)
} 
function Alert(message)
{
    alert(message);
}

function PopupWindow_wh(url,pageWidth,pageHeight)
{ 
    window.open(url,'PlexPopup','toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=' + pageWidth + ',height=' + pageHeight + ',left=40,top=25');
}

function PopupWindow(url)
{
    window.open(url,'PlexPopup','toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=100,height=50,left=40,top=25');
}
