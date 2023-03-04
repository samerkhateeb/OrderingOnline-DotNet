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
/// Summary description for Search_DAL
/// </summary>
/// 
namespace KFGCMS.BLL
{
    public class Search_DAL
    {
        public Search_DAL()
        {

        }

        public static DataSet SearchResults(string searchString, string quoteStatus, string language)
        {
            return (DataSet)SqlHelper.ExecuteDataset(ConnectionManager.GetConnection(), "SP_OBJECT_SEARCH", searchString, quoteStatus, language);

        }
    }
}
