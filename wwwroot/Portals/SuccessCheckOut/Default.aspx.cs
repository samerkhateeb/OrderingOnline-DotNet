using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KFGCMS.BLL;

public partial class Modules_SuccessCheckOut_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dataSet = Pages_BLL.ObjectData_Static();
        Master.StaticContent(dataSet);
    }
}