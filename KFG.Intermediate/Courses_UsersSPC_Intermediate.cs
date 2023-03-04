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
    public class Courses_UsersSPC_Intermediate:iIntermediate
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(object Info)
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteNoneQuery(new Courses_UserSPC_BLL().Insert((Courses_UsersSPC_Info)Info));
        }

        public void update(object QInfo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
