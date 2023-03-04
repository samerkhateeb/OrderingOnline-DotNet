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

public partial class Controls_UC_PageControl : System.Web.UI.UserControl
{
    

    public string PageContent
    {
        set
        {
            ContentLabel.Text = value;
        }
    }
    public string PageTitle
    {
        set
        {
            TitleLabel.Text = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
