using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using KFGCMS.BLL;

namespace Search
{
    public partial class Search_Result : System.Web.UI.UserControl
    {
        public event EventHandler PageRequest;

        public DataTable DataContent
        {

            set
            {

                String emptyDataText;
                DataTable dataTable = value;


                if (QueryString_Info.Language == "arb" || String.IsNullOrEmpty(QueryString_Info.Language))
                {
                    emptyDataText = "لا يوجد نتائج مطابقة لبحثك ... يرجى المحاولة مرة أخرى";
                    SearchLabel.Text = String.Format("نتيجة البحث / {0}", Request.QueryString["search"]);
                }
                else
                {
                    emptyDataText = "<br /><CENTER><b>There is no results mach your request! please try again...</b></CENTER>";
                    SearchLabel.Text = string.Format(@"Search Result \ {0}", Request.QueryString["search"]);
                }

                SearchLabel.DataBind();

                ResultGridView.DataSource = dataTable;
                ResultGridView.EmptyDataText = emptyDataText;
                ResultGridView.DataBind();

            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void ResultGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow grvRow = (GridViewRow)((Control)e.CommandSource).Parent.Parent;
            string selectedRowKey = (string)ResultGridView.DataKeys[grvRow.RowIndex].Value;

            PageRequest(String.Format("3 {0}", selectedRowKey), e);

        }
        protected string DateFormat(string sDate)
        {

            DateTime dateTime = Convert.ToDateTime(sDate);
            return dateTime.ToString("dd - MMMM - yyyy - ( h:mm tt )", CultureInfo.CreateSpecificCulture("ar-jo"));

        }
    }
}