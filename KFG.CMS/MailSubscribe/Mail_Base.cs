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
/// Summary description for Mail_Base
/// </summary>
namespace KFGCMS.BLL
{
    public class Mail_Base
    {
        public Mail_Base()
        {

        }

        public static SqlConnection ConnectionManager()
        {
            return Global_Base.Getconnection();
        }
    }
}
