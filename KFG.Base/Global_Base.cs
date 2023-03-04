using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace KFGCMS.BASE
{
    public class Global_Base
    {

        private Global_Base()
        { }

        private static SqlConnection _Connection;
        public static SqlConnection GetConnection()
        {
            //if (_Connection == null || _Connection.State == ConnectionState.Closed)
            {
                _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KFGCMS_ConnectionString"].ConnectionString);
                _Connection.Open();
            }
            return _Connection;

        }


        private static SqlConnection _COTConnection;
        public static SqlConnection GetCOTConnection()
        {
            //if (_COTConnection == null || _COTConnection.State == ConnectionState.Closed)
            {
                _COTConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["KFGCOT_ConnectionString"].ConnectionString);
                _COTConnection.Open();
            }
            return _COTConnection;

        }


    }
}
