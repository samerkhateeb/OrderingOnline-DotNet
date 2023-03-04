using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KFGCMS.BLL;
using System.Data.SqlClient;
using System.Data;

namespace KFGCMS.BLL
{
   public class QuestionnaireDetails_Bridge:Global_Base
    {

     
        public static DataSet Select(int questionnaireID, string language)
        {
            SqlCommand Command = new SqlCommand();
            SqlConnection Connection = new SqlConnection();
            SqlDataAdapter Dap = new SqlDataAdapter(Command);
            DataSet dataSet = new DataSet();

            try
            {
                using (Connection = Getconnection())
                {
                    Command.CommandText = "SP_QuestionsAnswers_SELECT";
                    Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;
                    Command.Parameters.Add("@QuestionnaireID", SqlDbType.Int).Value = questionnaireID;
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




        public static void Insert(List<QuestionnaireDetails_Info> QuestionnaireDetailsList)
        { 
            SqlCommand Command = new SqlCommand();
            SqlConnection Connection = new SqlConnection();
           
            
            try
            { 
               
               
                   

                    foreach (QuestionnaireDetails_Info QuestionnaireDetailsInfo in QuestionnaireDetailsList)
                    {
                        Command = new SqlCommand("SP_QuestionnaireValues_Insert");
                        
                        Command.CommandType = CommandType.StoredProcedure;
                      using (Connection = Getconnection())
                        {
                       
                        Command.Connection = Connection;

                        Command.Parameters.Add("@QuestionnaireID", SqlDbType.BigInt).Value = QuestionnaireDetailsInfo.QuestionnaireID;
                        Command.Parameters.Add("@QuestionnaireStatus", SqlDbType.Bit).Value = QuestionnaireDetailsInfo.QuestionnaireStatus;
                        Command.Parameters.Add("@QuestionID", SqlDbType.BigInt).Value = QuestionnaireDetailsInfo.QuestionID;
                        Command.Parameters.Add("@QuestionType", SqlDbType.Int).Value = QuestionnaireDetailsInfo.QuestionType;
                        Command.Parameters.Add("@AnswerVariable", SqlDbType.NVarChar).Value = QuestionnaireDetailsInfo.AnswerVariable;
                        Command.Parameters.Add("@AnswerIDs", SqlDbType.NVarChar).Value = QuestionnaireDetailsInfo.AnswerIDs;
                        Command.Parameters.Add("@userID", SqlDbType.Int).Value = QuestionnaireDetailsInfo.UserID;


                        Command.Transaction = Connection.BeginTransaction();
                        Command.ExecuteNonQuery();
                        Command.Transaction.Commit();


                    }
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
