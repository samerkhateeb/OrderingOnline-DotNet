using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KFGCMS.BLL
{
    public class Join_Bridge
    {
        public void Insert(Join_Info info)
        {

            SqlConnection connection = Global_BLL.GetConnection();
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }
            SqlCommand command = new SqlCommand(@"Insert into PlexCMS_Join (Join_Name, Join_Mobile, Join_Email, Join_Country, Join_Description, Join_Date) values 
                                                (@param1, @param2, @param3, @param4, @param5, @param6)", connection);

            command.Parameters.Add("@param1", SqlDbType.NVarChar).Value = info.Name;
            command.Parameters.Add("@param2", SqlDbType.NVarChar).Value = info.Mobile;
            command.Parameters.Add("@param3", SqlDbType.NVarChar).Value = info.Email;
            command.Parameters.Add("@param4", SqlDbType.NVarChar).Value = info.Country;
            command.Parameters.Add("@param5", SqlDbType.NVarChar).Value = info.Description;
            command.Parameters.Add("@param6", SqlDbType.DateTime).Value = info.DateTime;

            command.ExecuteNonQuery();

            connection.Close();
        }




    }
}
