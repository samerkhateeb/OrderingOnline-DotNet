using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFGCMS.BLL
{
    public class MailList_BLL
    {
        public static void MailList_Insert(string email, string description)
        {
            MailList_DAL.MailList_Insert(email, description);
        }
    }
}
