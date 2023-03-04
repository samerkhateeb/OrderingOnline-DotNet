using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFGCMS.BLL;
using System.Data;

public partial class Portals_Content_Default : System.Web.UI.Page
{
    string tableType;
    bool commentStatus = true;
    DataSet SubpageContainerDataSet = new DataSet();
    DataRow row;

    public string DataTableType(DataTable dataTable)
    {
        row = dataTable.Rows[0];
        return row["TableType"].ToString();
    }

    public void HideControl(Control control)
    {
        control.Visible = false;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {

                Global_BLL.DecodeUrl(Request.QueryString["info"]);
                Site_Info.CurrentLanguage = Pages_BLL.GetLanguage();


                // request data from database according to page type and id
                DataSet dataSet = Pages_BLL.ObjectData(QueryString_Info.ID, QueryString_Info.Source, QueryString_Info.Type, QueryString_Info.Language);

                foreach (DataTable dataTable in dataSet.Tables)
                {
                    // get table type
                    tableType = DataTableType(dataTable);

                    // check if table is empty or not
                    if (row[0].ToString().ToLower() == "empty")
                    {
                        continue;
                    }

                    switch (tableType.ToLower())
                    {
                        case "content":
                            {
                                // Init Page Title
                                Pages_BLL.ChangePageTitle(this.Page, dataSet.Tables[0].Rows[0]["Name"].ToString());

                                // bind page content
                                ContentControl.DataContent = dataSet.Tables[0];

                                break;
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