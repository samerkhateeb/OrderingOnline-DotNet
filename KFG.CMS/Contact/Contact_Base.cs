using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace KFGCMS.BLL
{
    public class Contact_Base
    {
        public static SqlConnection GetConnection()
        {
            return Global_Base.Getconnection();
        }

    }
}
