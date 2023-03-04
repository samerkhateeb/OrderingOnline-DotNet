using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFGCMS.BLL;
using System.Data;

public partial class Portals_CheckOut_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                //HttpCookie customerCookie = Request.Cookies["CustomerInfo"];
                //if (customerCookie == null)
                //{
                //    Response.Redirect("~/Portals/login?i=checkout");
                //}

                DataSet dataSet = Pages_BLL.ObjectData_Static();
                Master.StaticContent(dataSet);


            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);

            }
        }
    }
}