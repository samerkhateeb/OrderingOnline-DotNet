using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Plex.CMS.PlexDAL;
using System.Configuration;
using Plex.CMS.PlexControlPanel;

namespace Plex.CMS.PlexIntermediate
{
    public class Question_Intermediate:iIntermediate
    {



        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new Question_BLL().Select()));
        }

        public DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new Question_BLL().Select(id)));
        }

        public void Delete(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Question_BLL().Delete(id));
        }

        public int Insert(object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new Question_BLL().Insert(QInfo));
        }

        public void update(object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Question_BLL().Update(QInfo));
        }

        public int Select_QuestionAnswersCount(int questionID)
        {
             PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
             return PlexDataAccess.ExecuteScaler(new Question_BLL().Select_QuestionAnswersCount(questionID));       
        }
       

        

        #endregion
    }
}
