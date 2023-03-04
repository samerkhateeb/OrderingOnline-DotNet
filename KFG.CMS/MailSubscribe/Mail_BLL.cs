using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;

/// <summary>
/// Summary description for Mail_BLL
/// </summary>
namespace KFGCMS.BLL
{
    public class Mail_BLL
    {
        public Mail_BLL()
        {
        }

        public static bool SendEmail(string strFrom, string strBody, string strSubject, DateTime dateTime)
        {


            EmailInsert(strFrom, dateTime);
            string strEmailTo = ConfigurationManager.AppSettings["EmailTo"].ToString();
            MailMessage message = new MailMessage(strEmailTo, strFrom);
            message.Subject = strSubject;
            message.IsBodyHtml = true;
            message.Body = strBody;
            SmtpClient smtp = new SmtpClient("localhost");
            message.Priority = MailPriority.High;
            smtp.Send(message);
            return true;


        }
        public static void EmailInsert(string email, DateTime dateTime)
        {
            Mail_DAL.EmailInsert(email, dateTime);
        }
    }
}