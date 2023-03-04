using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PageCategories
{
    public partial class PageCategories : System.Web.UI.UserControl
    {
        public DataTable DataContent
        {
            set
            {
                DataTable dataTable = value;
                DataRow row = dataTable.Rows[0];


                //HeaderLabel.Text = row["Parent_Title"].ToString();
                BodyLabel.Text = row["Parent_Body"].ToString();

                
                if (dataTable.Rows.Count != 0)
                {
                    CategoryDataList.DataSource = dataTable;
                    CategoryDataList.DataBind();
                }

            }
        }
    }
}