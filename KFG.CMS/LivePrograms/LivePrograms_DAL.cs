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
using System.Data.SqlClient;

/// <summary>
/// Summary description for LivePrograms_DAL
/// </summary>
namespace KFGCMS.BLL
{
    public class LivePrograms_DAL
    {
        public LivePrograms_DAL()
        {

        }
        public static DataSet LivePrograms_DALContent()
        {
            DataSet ds;

            return ds = SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_LIVEPROGRAMS_CONTENT");

        }
    }
}