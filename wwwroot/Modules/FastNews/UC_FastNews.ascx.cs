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

public partial class Portals_Controls_UC_FastNews : System.Web.UI.UserControl
{
    public DataTable DataContent
    {
        set
        {
            FastLabel.Text = ((DataTable)value).Rows[0]["FASTNEWS_Name"].ToString();
            FastLabel.DataBind();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
