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
/// Summary description for LivePrograms_BLL
/// </summary>
namespace KFGCMS.BLL
{
    public class LivePrograms_BLL
    {
        public LivePrograms_BLL()
        {

        }
        public static DataSet LivePrograms_Content()
        {
            return LivePrograms_DAL.LivePrograms_DALContent();
        }


    }
}
