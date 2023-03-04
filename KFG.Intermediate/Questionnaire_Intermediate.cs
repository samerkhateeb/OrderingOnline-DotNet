using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Plex.CMS.PlexDAL;
using Plex.CMS.PlexControlPanel;
using System.Configuration;


namespace Plex.CMS.PlexIntermediate
{
    public class Questionnaire_Intermediate:iIntermediate
    {
        
        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new Questionnaire_BLL ().Select()));

        }

        public DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new Questionnaire_BLL().Select(id)));
        }

        public void Delete (int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Questionnaire_BLL ().Delete (id));
        }

        public int Insert (object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new Questionnaire_BLL ().Insert (QInfo));

        }

        public void update (object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings ["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Questionnaire_BLL().Update (QInfo));
        }

        #endregion
    }
}
