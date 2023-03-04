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
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for SubScribe
/// </summary>
namespace KFGCMS.BLL
{
    public class SubScribe
    {
        public SubScribe()
        {
        }
        public static void SendEmail(string email, string Date)
        {
            SqlHelper.ExecuteNonQuery(Global_Base.Getconnection(), "SP_SUBSCRIBE_EMAILS", email, Date);
        }
    }
}
