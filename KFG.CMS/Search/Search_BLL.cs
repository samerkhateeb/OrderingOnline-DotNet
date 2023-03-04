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

/// <summary>
/// Summary description for Search_BLL
/// </summary>
/// 
namespace KFGCMS.BLL
{
    public class Search_BLL
    {
        public Search_BLL()
        {

        }

        public static DataSet SearchResults(string searchString, string quoteStatus, string language)
        {
            return Search_DAL.SearchResults(searchString, quoteStatus, language);
        }
    }
}