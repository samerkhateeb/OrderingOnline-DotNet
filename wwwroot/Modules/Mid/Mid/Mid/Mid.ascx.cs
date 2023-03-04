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


public partial class Portals_Controls_UC_MidContainer : System.Web.UI.UserControl
{
    int loopIndex = 0, TablesCount = 0;

    public DataSet DataContent
    {
        set
        {
            DataSet dataSet = value;

            TablesCount = dataSet.Tables.Count;
            
            // dataView.RowFilter = "ParentID=" + dataTable.Rows[0]["parentid"];
            DataRow rowView = dataSet.Tables[0].Rows[0];
            DataTable masterDataTable = new DataTable();
            masterDataTable.Columns.Add(new DataColumn("ParentID"));
            
            // this to create parent rows according to the tables inside it.
            for (loopIndex = 0; loopIndex < TablesCount; loopIndex++)
                masterDataTable.ImportRow(rowView);
            
            // bind it to parent gridview 
            MidGridView.DataSource = masterDataTable;
            MidGridView.DataBind();
            loopIndex = 0;
            foreach( DataTable dataTable in dataSet.Tables)
            {

                // find the row to get child gridview inside
                GridViewRow row = MidGridView.Rows[loopIndex];

                    // Init Grid Items
                    GridView gridView = (GridView)row.FindControl("MidDetailsGridView");
                    gridView.DataSource = dataTable;
                    gridView.DataBind();
                    
                    // Init Grid Header
                    GridViewRow HeaderRow = gridView.HeaderRow,
                                FooterRow = gridView.FooterRow;

                    HyperLink HeaderHyperLink = row.FindControl("HeaderHyperLink") as HyperLink;
                if (HeaderHyperLink!=null)
                {
                    HeaderHyperLink.Text = dataTable.Rows[0]["PARENT_Name"].ToString();
                    HeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(dataTable.Rows[0]["ParentID"], "Category", dataTable.Rows[0]["Parent_Type"], dataTable.Rows[0]["Parent_StaticLink"]);
                    HeaderHyperLink.DataBind();
                }
                    //HyperLink FooterHyperLink = FooterRow.FindControl("MoreHyperLink") as HyperLink;
                    //FooterHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(dataTable.Rows[0]["ParentID"], String.Format("{0}", "CATEGORY"), dataTable.Rows[0]["Parent_Type"], dataTable.Rows[0]["PARENT_STATICLINK"]);
                   // HeaderHyperLink.Text = dataTable.Rows[0]["PARENT_Name"].ToString();
                
                    loopIndex++;    
                
            }
            
        }

    }

    protected void Page_Load(object sender, EventArgs e)
       {

    }
}
