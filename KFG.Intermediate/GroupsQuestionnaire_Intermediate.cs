using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Plex.CMS.PlexControlPanel;
using Plex.CMS.PlexDAL;
using System.Configuration;

namespace Plex.CMS.PlexIntermediate
{
    public class GroupsQuestionnaire_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new GroupsQuestionnaire_BLL().Select());
        }

        public DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new GroupsQuestionnaire_BLL().Select(id));
        }

        public void Delete(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new GroupsQuestionnaire_BLL().Delete(id));
        }

        public int Insert(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new GroupsQuestionnaire_BLL().Insert(oInfo), true);
        }

        public void update(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new GroupsQuestionnaire_BLL().Update(oInfo));
        }

        #endregion
    }
}
