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
    public class Groups_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new Groups_BLL().Select());
        }

        public DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new Groups_BLL().Select(id));
        }

        public void Delete(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteScaler(new Groups_BLL().Delete(id));
        }

        public int Insert(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new Groups_BLL().Insert((Groups_Info)oInfo),true);
        }

        public void update(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Groups_BLL().Update((Groups_Info)oInfo));
        }

        #endregion
    }
}
