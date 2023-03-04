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
    public class Careers_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return (PlexDataAccess.ExecuteDataSet(new Careers_BLL().Select()));
        }

        public System.Data.DataSet Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
             PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            PlexDataAccess.ExecuteNoneQuery(new Careers_BLL().Delete(id));
        }

        public int Insert(object oInfo)
        {
            throw new NotImplementedException();
        }

        public void update(object oInfo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
