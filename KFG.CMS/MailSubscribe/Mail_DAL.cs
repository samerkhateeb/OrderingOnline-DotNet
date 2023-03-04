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
/// Summary description for Mail_DAL
/// </summary>
namespace KFGCMS.BLL
{
    public class Mail_DAL
    {
        public Mail_DAL()
        {
        }


        public static void EmailInsert(string email, DateTime dateTime)
        {
            SqlHelper.ExecuteNonQuery(Mail_Base.ConnectionManager(), "SP_SUBSCRIBE_EMAILS", email, dateTime);
        }
    }
}
