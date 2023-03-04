using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plex.CMS.PlexControlPanel;
using Plex.CMS.PlexDAL;
using System.Configuration;
using System.Data;

namespace Plex.CMS.PlexIntermediate
{

    public class Courses_Users_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public System.Data.DataSet Select()
        {
            throw new NotImplementedException();
        }

        public DataSet Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(object UInfo)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteScaler(new Courses_Users_BLL().Insert((Courses_Users_Info)UInfo));
        }

        public void update(object QInfo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
