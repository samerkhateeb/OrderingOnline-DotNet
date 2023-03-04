using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KFGCMS.BLL
{
    class Voting_Base
    {
        public static SqlConnection GetConnection()
        {
            return Global_Base.Getconnection();
        }

    }
}
