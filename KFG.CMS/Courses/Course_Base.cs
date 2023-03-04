using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KFGCMS.BLL;

namespace Plex.CMS.PlexCode
{
   class Course_Base
    {

        public static SqlConnection GetConnection()
        {
            return Global_Base.Getconnection();
        }
    }
}
