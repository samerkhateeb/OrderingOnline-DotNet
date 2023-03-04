using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KFGCMS.BLL
{
    public class ForgetPassword_Bridge:Global_Base
    {

        public string CheckUserEmail(string email)
        {
           SqlCommand Command = new SqlCommand("SP_COURSE_User_ForgetPassword");
            SqlConnection Connection = new SqlConnection();
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet dataSet = new DataSet();
            try
            {
                Command.CommandType = CommandType.StoredProcedure;

                using (Connection = Getconnection())
                {

                    Command.Connection = Connection;

                    Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = email;

                    Adapter.Fill(dataSet);

                    if (dataSet.Tables[0].Rows[0][0].ToString() != "0")
                    {
                        ForgetPassword_Info.Name = dataSet.Tables[0].Rows[0][0].ToString();
                        ForgetPassword_Info.password = dataSet.Tables[0].Rows[0][1].ToString();
                    }

                    return dataSet.Tables[0].Rows[0][0].ToString();

                }

            }

            catch (Exception exc)
            {
                Command.Transaction.Rollback();
                Connection.Close();
                throw exc;
            }
        }

    }
}
