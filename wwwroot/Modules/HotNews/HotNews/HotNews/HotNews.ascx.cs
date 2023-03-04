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
using System.Text;
using KFGCMS.BLL;
using HotNews_Module;
using System.Collections.Generic;

public partial class HotNews : System.Web.UI.UserControl
{

    public DataTable DataContent
    {
        set
        {
            DataTable NewsDataTable = value;

            List<string> NewsResult = HotNews_BLL.Generate(NewsDataTable);



            ItemLiteral.Text = NewsResult[0];
           // ULLiteral.Text = NewsResult[1];


            this.DataBind();
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
