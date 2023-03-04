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
/// Summary description for Articles
/// </summary>

namespace KFGCMS.BLL
{
    public class Articles
    {
        public Articles()
        {

        }
        public static DataSet Articles_Default(string page_id)
        {

            DataSet ds = new DataSet();
            using (SqlConnection Conn = Global_Base.Getconnection())
            {
                ds = SqlHelper.ExecuteDataset(Conn, "SP_PAGE_TOP3", page_id);

            }
            return ds;

        }




    }
}
