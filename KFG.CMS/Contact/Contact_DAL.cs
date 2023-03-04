using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace KFGCMS.BLL
{
    class Contact_DAL
    {
        /// <summary>
        /// Insert Contact to DataBase
        /// </summary>
        /// <param name="name"> user name </param>
        /// <param name="email"> user email </param>
        /// <param name="side"> to whome this contact will be sent </param>
        /// <param name="message"> contact message </param>
        public static void SendContact(string name, string email, string side, string message)
        {
            SqlHelper.ExecuteNonQuery(Contact_Base.GetConnection(), "SP_CONTACT_INSERT", name, email, side, message, DateTime.Now.AddHours(8));

        }

    }
}
