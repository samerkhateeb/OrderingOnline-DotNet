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

/// <summary>
/// Summary description for CounterManager
/// </summary>
namespace KFGCMS.BLL
{
    public class CounterManager
    {
        public static string CounterSelectAll()
        {
            DataSet ds = new DataSet();
            using (SqlConnection Conn = Global_Base.Getconnection())
            {
                SqlCommand cmd = new SqlCommand("SP_COUNTERSELECT", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dap = new SqlDataAdapter(cmd);

                dap.Fill(ds);

            }
            return ds.Tables[0].Rows[0]["Count_Number"].ToString();

        }
        public static void CounterUpdate()
        {
            using (SqlConnection Conn = Global_Base.Getconnection())
            {
                SqlCommand cmd = new SqlCommand("SP_COUNTER", Conn);
                // cmd.Parameters.Add("@COUNTER_NEW", SqlDbType.BigInt).Value = NewCount;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }

        }
    }
}