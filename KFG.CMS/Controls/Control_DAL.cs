using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace KFGCMS.BLL
{
    class Control_DAL
    {

        public static DataSet ControlSelect(string controlID, string Laguage)
        {
            return SqlHelper.ExecuteDataset(Contact_Base.GetConnection(), "SP_CONTROL_SELECT", controlID, Laguage);
        }

    }
}
