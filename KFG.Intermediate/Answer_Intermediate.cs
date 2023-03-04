using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plex.CMS.PlexIntermediate;
using System.Data;
using Plex.CMS.PlexControlPanel;
using Plex.CMS.PlexDAL;
using System.Configuration;
namespace Plex.CMS.PlexIntermediate
{
    public class Answer_Intermediate:iIntermediate
    {
        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new QAnswer_BLL().Select()));
        }

        public DataSet Select(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new QAnswer_BLL().Select(id)));

        }

        public void Delete(int id)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new QAnswer_BLL().Delete(id));
        }

        public int Insert(object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new QAnswer_BLL().Insert(QInfo),true);
        }

        public void update(object QInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new QAnswer_BLL().Update(QInfo));
        }

        

        #endregion
    }
}
