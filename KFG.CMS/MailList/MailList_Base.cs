using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KFGCMS.BLL;

namespace KFGCMS.BLL
{
    public class MailList_Base
    {
       public static SqlConnection GetConnection()
        {
            return Global_Base.Getconnection();
        }
    }
}
