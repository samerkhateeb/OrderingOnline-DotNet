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
using System.Xml;
using KFGCMS.BLL;

public partial class Portals_Controls_UC_Weather : System.Web.UI.UserControl
{
    public string DataContent
    {
        set
        {
            try
            {
                String location = value;

                XmlTextReader reader = new XmlTextReader(String.Format("http://xml.weather.yahoo.com/forecastrss?p={0}&u=c", location));
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);

                WeatherLabel.Text = dataSet.Tables["Item"].Rows[0]["Description"].ToString();
                WeatherLabel.DataBind();
            }
            catch (Exception exc)
            {
                WeatherLabel.Text = "نعتذر الطقس الآن غير متاح من المصدر... يرجى المحاولة لاحقاُ";
               // Global_BLL.FireException(this, exc.Message);
            }
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
