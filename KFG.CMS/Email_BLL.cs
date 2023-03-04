using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;
using System.Net;

namespace KFGCMS.BLL
{
    public class Email_BLL
    {

        public int Send(string Subject, string To, string Body)
        {
            try
            {

                MailMessage message = new MailMessage
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["AdminEmail"].ToString()),
                    Subject = Subject,
                    SubjectEncoding = Encoding.UTF8,
                    Body = Body,
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };
                message.To.Add(new MailAddress(To));
                SmtpClient smtp;
                //if (To.ToLower().Contains("kfg.com.kw"))
                //    smtp = new SmtpClient("mail.homaizi.com");
                //else
                {
                    smtp = new SmtpClient(ConfigurationManager.AppSettings["SMTPMailServer"]);
                    smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["AdminEmail"], ConfigurationManager.AppSettings["AdminPassword"]);
                }

                smtp.Send(message);
                return 1;
            }
            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);

                return 0;
            }


        }


    }
}
