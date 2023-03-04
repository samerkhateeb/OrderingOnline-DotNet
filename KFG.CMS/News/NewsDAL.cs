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
/// Summary description for NewsDAL
/// </summary>
namespace KFGCMS.BLL
{
    public class NewsDAL
    {
        public static DataSet NewsDBGenerator()
        {
            return (DataSet)SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_NEWS_SELECT");
        }
    }
}