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
using KFGCMS.BLL;

public partial class Portals_Controls_UC_Discussions : System.Web.UI.UserControl
{

    public DataTable DataContent
    {
        set
        {
            DataTable dataTable = value;

            if ((bool)dataTable.Rows[0]["Parent_Status"])
            {
                DiscussionsGridView.Visible = true;

                DiscussionsGridView.DataSource = dataTable;
                DiscussionsGridView.DataBind();

                // Init Grid Header
              //  GridViewRow HeaderRow = DiscussionsGridView.HeaderRow;
               // Label HeaderLabel = HeaderRow.FindControl("HeaderLabel") as Label;
                HeaderLabel.Text = Pages_BLL.SettingsReturn().Tables[0].Rows[0]["HomeSetting_DiscussionsTitle"].ToString();
                HeaderLabel.DataBind();

            }
            else
            {
                DiscussionsGridView.Visible = false;
            }
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
