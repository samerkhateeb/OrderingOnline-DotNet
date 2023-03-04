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
using System.Data.OleDb;

/// <summary>
/// Summary description for ConnectionManager
/// </summary>
namespace KFGCMS.BLL
{
    public class ConnectionManager
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString; }
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString);
            conn.Open();
            return conn;
        }


    }
}
