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
/// Summary description for Visitors_DAL
/// </summary>
namespace KFGCMS.BLL
{
    public class Visitors_DAL
    {
        public Visitors_DAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static DataSet Visitor_Country(string ipNum)
        {
            DataSet ds;
            return ds = SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_COUNTERUPDATE", ipNum);
        }


        public static DataSet VisitorsCount()
        {
            return (DataSet)SqlHelper.ExecuteDataset(ConnectionManager.GetConnection(), "SP_Visitors_Count");

        }
    }
}