using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Plex.CMS.PlexDAL;
using Plex.CMS.PlexControlPanel;
using System.Configuration;
using System.Data.SqlClient;


namespace Plex.CMS.PlexIntermediate
{
    public class QuestionnaireValues_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public DataSet Select()
        {
            throw new NotImplementedException();
        }

        public DataSet Select(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet Select(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new QuestionnaireValues_BLL().Select((QuestionnireValues_Info)oInfo));
        }

        public DataSet SelectQuestionnaireUsers(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new QuestionnaireValues_BLL().SelectQuestionnaireUsers((QuestionnireValues_Info)oInfo));
        }


        void iIntermediate.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new QuestionnaireValues_BLL().Insert(oInfo),true);
        }

        public void update(object oInfo)
        {
            throw new NotImplementedException();
        }

        //public void Update_Question(int questionID, int questionnaireID, int questionType)
        //{
        //     PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
        //    PlexDataAccess.ExecuteNoneQuery(new QuestionnaireValues_BLL().Update_Question(questionID,questionnaireID,questionType));
        //}


        // /// <summary>
        ///// Update Answer From One Question To Another
        ///// </summary>
        ///// <param name="Answer_ID">Answer ID To Change Question For</param>
        ///// <param name="question_ID">New Question ID To Be Changing</param>
        ///// <returns></returns>
        //public void Update_Answer(int Answer_ID, int question_ID)
        //{
        //    PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
        //    PlexDataAccess.ExecuteNoneQuery(new QuestionnaireValues_BLL().Update_Answer(Answer_ID, question_ID));
        //}


        /// <summary>
        /// delete Answer from Values table
        /// </summary>
        /// <param name="oID">Answer ID</param>
        /// <returns></returns>
        public void Delete_Answer(int oID)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new QuestionnaireValues_BLL().Delete_Answer(oID));
        }

        /// <summary>
        /// delete Question from Values table
        /// </summary>
        /// <param name="oID">Question ID</param>
        /// <returns></returns>
        public void Delete_Question(int oID)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new QuestionnaireValues_BLL().Delete_Question(oID));
        }


        #endregion
    }
}
