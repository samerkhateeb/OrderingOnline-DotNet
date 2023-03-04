using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace KFGCMS.BLL
{
    public class Email_BLL
    {
        public Email_BLL()
        {
        }

        public void Send(Email_Info contactInfo)
        {
            Send(contactInfo.Subject, ConfigurationManager.AppSettings["EmailTo"].ToString(), contactInfo.To, contactInfo.Body, contactInfo.SenderName);
        }

        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="name">Sender Name</param>
        /// <param name="fromEmail">From Sender Email</param>
        /// <param name="toEmail">To Recipient Email</param>
        /// <param name="ccEmail">CC Email</param>
        /// <param name="bccEmail">BCC Email</param>
        /// <param name="subject">Subject Email</param>
        /// <param name="body">Body Email</param>
        public void Send(string subject, string from, string to, string body)
        {
            Send(subject, from, to, body, "");
        }

        public void Send(string subject, string from, string to, string body, string senderName)
        {
            if (!String.IsNullOrEmpty(senderName))
            {
                senderName = String.Format("<br clear='both' /> <div style='direction:rtl;'المرسل: {0}</div>", senderName);
            }

            MailMessage message = new MailMessage();

            message.From = new MailAddress(from, ConfigurationManager.AppSettings["SiteName"].ToString(), Encoding.UTF8);
            message.To.Add(to);
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.BodyEncoding = Encoding.UTF8;
            message.Body = "<div style='width:500px; height:auto; overflow:hidden; font:bold 16px/1.6 arial, tahoma, serif; text-align:right; direction:rtl; display:block'>" + body + senderName + "</div>";
            message.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient("localhost");
            smtp.Send(message);
        }



        public string SendEmail(string from, string to)
        {
            return SendEmail(from, to, "");
        }

        //public string SendEmail(string from, string fromName, string to, string toName)
        //{
        //    return SendEmail(from, fromName, to, toName, "");
        //}

        public string SendEmail(string from, string to, string subject)
        {
            return SendEmail(from, to, subject, "");
        }
        public string SendEmail(string from, string fromName, string to, string toName, string subject)
        {
            return SendEmail(from, fromName, to, toName, subject, "");
        }

        public string SendEmail(string from, string to, string subject, string body)
        {
             return SendEmail(from, "", to, "", subject, body,"");
        }

        public string SendEmail(string from, string fromName, string to, string toName, string subject, string body)
        {
            return SendEmail(from, fromName, to, toName, subject, body,"");
        }

        //public string SendEmail(string from, string to, string subject, string body, params string[] CC)
        //{
        //    return SendEmail(from, "", to, "", subject, body, CC);
        //}


        // Attachments, To Collection, CC Collection, BCC Collection, Also make Different Types
        public string SendEmail(string from,string fromName, string to, string toName, string subject, string body, params string[] CC)
        {
            try
            {
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress(from, fromName, Encoding.UTF8);
                Message.To.Add(new MailAddress(to,toName,Encoding.UTF8));
                Message.Subject = subject;
                Message.Body = body;
                Message.BodyEncoding = Encoding.UTF8;
                Message.IsBodyHtml = true;

                foreach (string ccEmail in CC)
                {
                    if (!String.IsNullOrEmpty(ccEmail))
                        Message.CC.Add(ccEmail);
                }

                //Message.Attachments.Add

                SmtpClient smtp = new SmtpClient("localhost");
                smtp.Send(Message);

                return "true";
            }

            catch (Exception exc)
            {
                return exc.Message ;
            }
    
        }


    }
}
