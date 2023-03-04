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
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for Media_BLL
/// </summary>
namespace KFGCMS.BLL
{
    public class Media_BLL
    {
        public Media_BLL()
        {

        }

        public static DataSet MediaEvents(string name_type, string mid, string intType, string dcatid)
        {
            return Media_DAL.MediaEvents(name_type, mid, intType, dcatid);
        }
        public static DataSet MediaCatID(string mid)
        {
            return Media_DAL.MediaCatID(mid);
        }
    }
}
