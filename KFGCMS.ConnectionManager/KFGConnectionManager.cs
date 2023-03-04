using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KFGCMS.ConnectionManager
{
    public class KFGConnectionManager
    {
        public SqlConnection Conn = null;


        public KFGConnectionManager(string Path)
        {
            Conn = new SqlConnection(Path);
            Conn.Open();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                Conn.Close(); // call close here to close connection
            }
        }

        ~KFGConnectionManager()
        {
            Dispose(false);
        }
    }
}
