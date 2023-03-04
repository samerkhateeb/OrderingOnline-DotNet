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
using System.Data;
using System.Threading;
using System.IO;
using System.Net;



/// <summary>
/// Summary description for Visitors_BLL
/// </summary>
namespace KFGCMS.BLL
{
    public class Visitors_BLL
    {
        public Visitors_BLL()
        {

        }

        public static DataSet IPAddressToNumber(string IPaddress)
        {
            DataSet ds = new DataSet();
            int i;
            string[] arrDec;
            double num = 0;
            if (IPaddress == "")
            {
                return ds;
            }
            else
            {
                arrDec = IPaddress.Split('.');
                for (i = (arrDec.Length - 1); i >= 0; i -= 1)
                {
                    num += ((int.Parse(arrDec[i]) % 256) * Math.Pow(256, (3 - i)));
                }
                return ds = Visitors_DAL.Visitor_Country(num.ToString());
            }
        }

        public static object VisitorsCount()
        {
            DataSet dataSet = Visitors_DAL.VisitorsCount();
            return dataSet.Tables[0].Rows[0]["COUNT_NUMBER"];

        }

    }
}
