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
    public class Courses_Intermediate:iIntermediate
    {

        #region iIntermediate Members

        public DataSet Select()
        {
            PlexDataAccess.ConnectionString = ConfigurationManager.ConnectionStrings["Plex_ConnectionString"].ConnectionString;
            return PlexDataAccess.ExecuteDataSet(new Courses_BLL().Select());
        }

        public DataSet Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(object QInfo)
        {
            throw new NotImplementedException();
        }

        public void update(object QInfo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
