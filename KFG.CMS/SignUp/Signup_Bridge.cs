using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace KFGCMS.BLL
{
   public class Signup_Bridge:Global_Base
    {
       
        public string Course_UserSignUp()
        { 
            SqlCommand Command = new SqlCommand("SP_COURSE_User_SignUp"); 
            SqlConnection Connection = new SqlConnection();
            string result;
            try
            {
                Command.CommandType = CommandType.StoredProcedure;
                using (Connection = Getconnection())
                {

                    Command.Connection = Connection;

                    Command.Parameters.Add("@NAme", SqlDbType.NVarChar).Value = Signup_Info.Name;
                    Command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar).Value = Signup_Info.Password;
                    Command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Signup_Info.email;
                    Command.Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Signup_Info.Phone;
                    Command.Parameters.Add("@COMMENT", SqlDbType.NVarChar).Value = Signup_Info.Comment;
                    Command.Parameters.Add("@DATE", SqlDbType.NVarChar).Value = Signup_Info.Date;

                    Command.Transaction = Connection.BeginTransaction();
                    result = Command.ExecuteScalar().ToString();
                    Command.Transaction.Commit();

                   
                }
                
                return result;
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
