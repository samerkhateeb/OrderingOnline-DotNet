using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KFGCMS.BLL;
using System.Net.Mail;
using System.Configuration;

namespace KFGCMS.BLL
{
    public class Contact_BLL
    {
        public static void SendContact(string name, string email, string side, string message)
        {
            Contact_DAL.SendContact(name, email, side, message);
        }


        public static void SendEmail(string subject,string from, string To, string body)
        {

            MailMessage message = new MailMessage(ConfigurationManager.AppSettings["EmailTo"].ToString(), To, subject, from + "<br />" + body);
            
            message.IsBodyHtml = true;
          
            message.BodyEncoding = Encoding.UTF8;
            message.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient("localhost");
            smtp.Send(message);
        }
    }
}
