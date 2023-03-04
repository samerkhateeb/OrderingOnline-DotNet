using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace KFGCMS.BLL
{
   internal class MailList_DAL:MailList_Base
    {

      internal static void MailList_Insert(string email, string description)
       {
           SqlHelper.ExecuteNonQuery(GetConnection(), "SP_MAILLIST_INSERT", email, description);
       }
    }
}
