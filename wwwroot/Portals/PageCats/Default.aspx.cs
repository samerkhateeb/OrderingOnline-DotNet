using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KFGCMS.BLL;

public partial class Portals_PageCats_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {


                // decode url
                Global_BLL.DecodeUrl(Request.QueryString["info"]);

                DataSet dataSet = Pages_BLL.ObjectData(QueryString_Info.ID, QueryString_Info.Source, QueryString_Info.Type);

                if (QueryString_Info.Type != "1")
                {
                    foreach (DataTable dataTable in dataSet.Tables)
                    {

                        if (dataTable.Rows.Count != 0 && dataTable.Rows[0]["tableType"].ToString().ToLower() == "categories_content")
                            {
                                PageCategoriesControl.DataContent = dataTable;
                            }

                        else
                            if (dataTable.Rows.Count != 0 && dataTable.Rows[0]["tableType"].ToString().ToLower() == "content")
                            {
                                Master.TopImage = dataTable.Rows[0]["THUMBNAIL"];

                            }
                    }
                }

                Master.StaticContent(dataSet);
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
                
            }
            
        }
    }
}