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

public partial class Portals_Controls_UC_MostEmailCommentVisit : System.Web.UI.UserControl
{
    string  tableType;

    public DataSet DataContent
    {
        set
        {
            DataSet dataSet = value;

            foreach (DataTable dataTable in dataSet.Tables)
            {
              //  tableIndex = dataSet.Tables.IndexOf(dataTable);

                tableType = dataTable.Rows[0]["MostType"].ToString();
                switch (tableType.ToLower())
                {
                    case "email": // EMAIL
                            EmailDataList.DataSource = dataTable;
                            EmailDataList.DataBind();
                            EmailTabPanel.Visible = true;
                            break;

                    case "comment": // PARTICIPATE
                            CommentDataList.DataSource = dataTable;
                            CommentDataList.DataBind();
                            CommentTabPanel.Visible = true;
                            break;

                    case "visit": // VIIST
                            VisitDataList.DataSource = dataTable;
                            VisitDataList.DataBind();
                            VisitTabPanel.Visible = true;
                            break;
                }

            }

        }
    }
}
