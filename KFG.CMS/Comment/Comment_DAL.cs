using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace KFGCMS.BLL
{
    class Comment_DAL
    {


        public static int Comment_Insert(object sourceID, string name,string email, string details, object sourceName, string date, string language)
        {
            return SqlHelper.ExecuteNonQuery(Comment_Base.GetConnection(), "SP_OBJECT_COMMENT_INSERT", sourceID, name, email, details, sourceName, date, language);
        }


    }
}
