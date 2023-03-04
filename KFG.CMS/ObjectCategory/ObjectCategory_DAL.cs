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
/// Summary description for ObjectCategory_DAL
/// </summary>
namespace Plex.CMS.PlexCMS
{
    public class ObjectCategory_DAL
    {
        public ObjectCategory_DAL()
        {
        }
        public static DataSet ObjectCategories(string pageID)
        {
            return (DataSet)SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_OBJECTCATEGORIES", pageID);
        }


        public static DataSet ObjectCategoryData(string dcID, string type)
        {
            return (DataSet)SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_OBJECTCATEGORY_DATA", dcID, type);
        }
    }
}
