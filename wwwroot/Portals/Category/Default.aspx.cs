using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KFGCMS.BLL;

public partial class Portals_Category_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            try
            {
                Global_BLL.DecodeUrl(Request.QueryString["info"]);
                // request data from database according to page type and id
                DataSet dataSet = Pages_BLL.ObjectData(QueryString_Info.ID, QueryString_Info.Source, QueryString_Info.Type);
                
                foreach (DataTable dataTable in dataSet.Tables)
                {
                    if (dataTable.Rows.Count != 0 && dataTable.Rows[0]["tableType"].ToString().ToLower() == "content")
                    {
                        CategoryControl.DataContent = dataTable;
                        Master.TopImage = dataTable.Rows[0]["PARENT_THUMBNAIL"];
                        break;
                    }
                }
                
                Master.StaticContent(dataSet);

                Master.Menu_PageCategories_Selected = QueryString_Info.ID;

                HttpCookie cookie = Request.Cookies["OrderType"];

                if (cookie == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "OrderTypeScript", "GoToOpenPopup(' ');", true);
                }

            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
                
            }
        }


    }
}