using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KFGCMS.Info;

namespace KFGCMS.BLL
{
    public class Careers_Bridge:Global_Base
    {
        public void Insert(Careers_Info CareersInfo)
        {
            SqlCommand Command = new SqlCommand();
            SqlConnection Connection = new SqlConnection();

            try
            {

                Command = new SqlCommand("SP_Careers_Insert");

                    Command.CommandType = CommandType.StoredProcedure;
                    using (Connection = Getconnection())
                    {

                        Command.Connection = Connection;

                        Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = CareersInfo.Name;
                        Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = CareersInfo.Email;
                        Command.Parameters.Add("@Specialization", SqlDbType.NVarChar).Value = CareersInfo.Specialization;
                        Command.Parameters.Add("@Experience", SqlDbType.Int).Value = CareersInfo.ExperienceYears;
                        Command.Parameters.Add("@PmpHolderStatus", SqlDbType.NVarChar).Value = CareersInfo.PMPHolder;
                        Command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = CareersInfo.Country;




                        if (!String.IsNullOrEmpty(CareersInfo.CV))
                            Command.Parameters.Add("@CV", SqlDbType.NVarChar).Value = (object)DBNull.Value;
                        else
                            Command.Parameters.Add("@CV", SqlDbType.NVarChar).Value = CareersInfo.CV;




                        if (!String.IsNullOrEmpty(CareersInfo.Phone.ToString()))
                            Command.Parameters.Add("@Phone", SqlDbType.BigInt).Value = (object)DBNull.Value; 
                        else
                            Command.Parameters.Add("@Phone", SqlDbType.BigInt).Value = CareersInfo.Phone;



                        Command.Transaction = Connection.BeginTransaction();
                        Command.ExecuteNonQuery(); 
                        Command.Transaction.Commit();


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
