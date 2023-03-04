using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banner
{
    public partial class Banner : System.Web.UI.UserControl
    {
        public string DataContent
        {
            set
            {
                BannerLabel.Visible = true;
                BannerLabel.Text = value;
                BannerLabel.DataBind();
            }
        }

    }
}