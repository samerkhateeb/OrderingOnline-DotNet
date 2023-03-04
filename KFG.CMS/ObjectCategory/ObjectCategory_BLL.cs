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
/// Summary description for ObjectCategory_BLL
/// </summary>
namespace Plex.CMS.PlexCMS
{
    public class ObjectCategory_BLL
    {
        public ObjectCategory_BLL()
        {
        }

        public static DataSet ObjectCategories(string pageID)
        {

            return (DataSet)ObjectCategory_DAL.ObjectCategories(pageID);
        }

        public static DataSet ObjectCategoryData(string dcID, string type)
        {
            return (DataSet)ObjectCategory_DAL.ObjectCategoryData(dcID, type);
        }
    }
}
