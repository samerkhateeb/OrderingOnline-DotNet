using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFGCMS.BLL;

namespace Search
{
    public partial class Search : System.Web.UI.UserControl
    {
        #region Members
        string searchText = "", qT = "";
        char[] chars = { '"', '\'' };

        #endregion


        public string Text
        {
            set
            {
                SearchTextBox.Text = value;
            }
        }

        public string WaterMarkText
        {
            set
            {
                SearchTextBox_TextBoxWatermarkExtender.WatermarkText = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SearchButton_Click(object sender, ImageClickEventArgs e)
        {
            searchText = SearchTextBox.Text;

            if (searchText.IndexOfAny(chars) != -1)
                qT = "true";
            else
                qT = "false";

            Search_Info.SearchText = searchText;

            Response.Redirect(String.Format("../Search/?info={0}&search={1}&qt={2}", Request.QueryString["info"], searchText.Trim(chars), qT));


        }
    }
}