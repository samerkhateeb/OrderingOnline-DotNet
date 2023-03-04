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
/// Summary description for Pages_Base
/// </summary>
namespace KFGCMS.BLL
{
    class Pages_Base
    {
        public Pages_Base()
        {
        }

        public static SqlConnection GetConnection()
        {
            return Global_Base.Getconnection();
        }
    }
}