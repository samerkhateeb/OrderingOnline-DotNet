using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using KFGCMS.BLL;

public partial class Portals_Controls_UC_ShortNews : System.Web.UI.UserControl
{
    public List<object> DataContent
    {
        set
        {
            ShortNewsLabel.Text = Pages_BLL.ShorNewsLink(value);
            ShortNewsLabel.DataBind();




            // <object codebase='http://www.microsoft.com/Windows/Downloads/Contents/MediaPlayer/' 
            //height='45' width='220' classid='CLSID:6BF52A52-394A-11D3-B153-00C04F79FAA6'>
            //<param name='URL' value='{0}' />
            //<param name='rate' value='1' />
            //<param name='balance' value='0' />
            //<param name='currentPosition' value='0' />
            //<param name='defaultFrame' value='' />
            //<param name='playCount' value='32767' />
            //<param name='autoStart' value='{1}' />
            //<param name='currentMarker' value='0' />
            //<param name='invokeURLs' value='-1' />
            //<param name='baseURL' value='' />
            //<param name='volume' value='50' />
            //<param name='mute' value='0' />
            //<param name='uiMode' value='full' />
            //<param name='stretchToFit' value='0' />
            //<param name='windowlessVideo' value='0' />
            //<param name='enabled' value='-1' />
            //<param name='enableContextMenu' value='-1' />
            //<param name='fullScreen' value='0' />
            //<param name='SAMIStyle' value='' />
            //<param name='SAMILang' value='' />
            //<param name='SAMIFilename' value='' />
            //<param name='captioningID' value='' />
            //<param name='enableErrorDialogs' value='0' />
            //<param name='_cx' value='8467' />
            //<param name='_cy' value='7673' />





        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            

        }
    }
}
