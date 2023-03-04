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

public partial class Portals_Controls_UC_SPGroups : System.Web.UI.UserControl
{

    public DataTable DataContent
    {
        set
        {
            DataTable dataTable = value;
            //HeaderLabel.Text = Site_Info.SPGroupsTitleText;
            
            // Init Grid Items
            GroupDetailsGridView.DataSource = dataTable;
            GroupDetailsGridView.DataBind();

            GridViewRow gridRow = GroupDetailsGridView.HeaderRow;
            Label labelTitle = gridRow.FindControl("HeaderLabel") as Label;
            labelTitle.Text = Site_Info.SPGroupsTitleText;
            
            // NO NEED TO Init Grid Header
            //GridViewRow HeaderRow = GroupDetailsGridView.HeaderRow;
            //Label HeaderLabel = HeaderRow.FindControl("HeaderLabel") as Label;
            //HeaderLabel.Text = dataTable.Rows[0]["DCAT_TITLE"].ToString();
                
               
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
