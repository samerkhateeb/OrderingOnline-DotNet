using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;



namespace KFGCMS.BLL
{
    public class Questionnaire_Bridge:Global_Base
    {
        public static DataSet Select(int groupID, string language)
        {
            SqlCommand Command = new SqlCommand();
            SqlConnection Connection = new SqlConnection();
            SqlDataAdapter Dap = new SqlDataAdapter(Command);
            DataSet dataSet = new DataSet();

            try
            {
                using (Connection = Getconnection())
                {
                    Command.CommandText = "SP_QUESTIONNAIRE_SELECT";
                    Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;
                    Command.Parameters.Add("@GroupID", SqlDbType.Int).Value = groupID;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Connection = Connection;

                    Dap.Fill(dataSet);


                    return dataSet;
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
