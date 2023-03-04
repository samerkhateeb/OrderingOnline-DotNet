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

public partial class Portals_Controls_UC_Content : System.Web.UI.UserControl
{

    public DataTable DataContent
    {
        set
        {
            DataTable dataTable = (DataTable)value;
            DataRow row = dataTable.Rows[0];

           // HeaderLabel.Text = row["Title"].ToString();

           // RootHyperLink.Text = row["Root_Title"].ToString();
           // RootHyperLink.NavigateUrl = Pages_BLL.GenerateMenuUrl(row["RootID"], "Page", row["Root_Type"], row["Root_StaticLink"]);

           // ParentHeaderHyperLink.Text = row["Parent_Title"].ToString();
           // ParentHeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ParentID"], "Category", row["Parent_Type"], row["Parent_StaticLink"]);
           // ParentHeaderHyperLink.DataBind();

           //// DateLabel.Text = Global_BLL.FilterDateToStandardFormat(row["Date"].ToString());
           // ThumbnailImage.ImageUrl = "../" + row["Thumbnail"].ToString();
           // if (Convert.ToUInt16(row["ThumbnailWidth"]) !=0)
           // ThumbnailImage.Width = Convert.ToUInt16(row["ThumbnailWidth"]);

           // if ( Convert.ToUInt16(row["ThumbnailHeight"])!=0)
           // ThumbnailImage.Height = Convert.ToUInt16(row["ThumbnailHeight"]);
           // ThumbnailImage.AlternateText = row["ThumbnailAlt"].ToString();

           // ThumbnailImage.Visible = Convert.ToBoolean(row["ThumbnailStatus"]);
           // EmailHyperLink.Attributes.Add("onClick", "javascript:SendEmail()");
            
           // this.DataBind();
            BodyLabel.Text = row["BODY"].ToString();
            
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
