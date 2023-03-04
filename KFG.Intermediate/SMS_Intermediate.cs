using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Plex.CMS.PlexDAL;
using Plex.CMS.PlexControlPanel;

namespace Plex.CMS.PlexIntermediate
{
    public class SMS_Intermediate:iIntermediate
    {
        #region iIntermediate Members

        public System.Data.DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet (new SMS_BLL().Select()));
        }

        public System.Data.DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet (new SMS_BLL().Select(id)));
        }

        public void Delete(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery (new SMS_BLL().Delete(id));
        }

        public int Insert(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new SMS_BLL().Insert(oInfo), true);
        }

        public void update(object oInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new SMS_BLL().Update(oInfo));
        }

        #endregion
    }
}
