using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KFGCMS.DAL
{
    public class KFGDAL_ConnectionManager:IDisposable
    {
        SqlConnection Conn = null;    

        public KFGDAL_ConnectionManager(string path)
        {
            SqlConnection conn = new SqlConnection(path);
            conn.Open();         
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
                Conn.Close(); 
            }
        }

        ~KFGDAL_ConnectionManager()
        {        
            Dispose(false);
        }



    }
}
