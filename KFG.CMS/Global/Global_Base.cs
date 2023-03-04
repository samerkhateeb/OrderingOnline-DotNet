using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Global_Base
/// </summary>
namespace KFGCMS.BLL
{
    public class Global_Base
    {
        static string[] separatorUrl = { "?" };
        static string[] separatorQuery = { "&", "=" };
        public Global_Base()
        {

        }

        public static SqlConnection Getconnection()
        {
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KFGCMS_ConnectionString"].ConnectionString);
            //connection.Open();
            //return connection;

            return KFGCMS.BASE.Global_Base.GetConnection();
        }

        public static SqlConnection GetCOTconnection()
        {
            return KFGCMS.BASE.Global_Base.GetCOTConnection();
        }


    }
}
