using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFGCMS.BLL;

public partial class Portals_CustomerAuthorization_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Master.StaticContent(Pages_BLL.ObjectData_Static());
        }
    }
}