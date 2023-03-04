using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace KFGCMS.BLL
{
    public class ExceptionsLog_BLL
    {

        //public static void SaveException(Exception exc, string Layer)
        //{
        //    SaveException(exc, Layer, "");
        //}

        public static void SaveException(Exception exception, string Layer, string ClassName)
        {
            try
            {

                Regex reg = new Regex("[/''' ]");
                
                string appPath = HttpContext.Current.Request.PhysicalApplicationPath + ConfigurationManager.AppSettings["LogFolderName"],
                       CurrentDate = DateTime.Now.ToString("dd/M/yyyy").Split(' ')[0],
                       fileName = String.Format("Log ({0}).txt", reg.Replace(CurrentDate,"-")),
                       CurrentTime = DateTime.Now.TimeOfDay.ToString().Substring(0,DateTime.Now.TimeOfDay.ToString().LastIndexOf('.'));
                FileInfo fileInfo = new FileInfo(appPath +"/"+ fileName);
                FileStream fileStream;
                StreamWriter w;
                if (fileInfo.Exists)
                {
                    fileStream = new FileStream(fileInfo.FullName, FileMode.Append, FileAccess.Write);
                    // w = File.CreateText(String.Format("{0}Log_{1}", appPath, DateTime.Now.ToString().Substring(0, 10)));
                }
                else
                    fileStream = new FileStream(fileInfo.FullName, FileMode.Create, FileAccess.ReadWrite);


                w = new StreamWriter(fileStream, Encoding.UTF8);

                // string filePath = appPath + "Text.txt";
                w.WriteLine(String.Format("/************* (Exception at {0}) *************/", CurrentTime));
                w.WriteLine(String.IsNullOrEmpty(exception.Message) ? "No Exception available" : "Exception : " +exception.Message);
               
                // Check if there is inner exception
                if (exception.InnerException != null && !String.IsNullOrEmpty(exception.InnerException.Message))
                {
                    w.WriteLine();
                    w.WriteLine(String.Format("/************* (INNER Exception at {0}) *************/", CurrentTime));
                    w.WriteLine(String.IsNullOrEmpty(exception.InnerException.Message) ? "No INNER Exception available" :  "INNER Exception Is: " +exception.InnerException.Message);    
                }

                w.WriteLine(String.Format("Layer Is  : {0}", Layer));
                w.WriteLine(String.Format("Class Name: {0}", ClassName));
                w.WriteLine(String.Format("Exc Body  : {0}", exception.StackTrace));
                w.WriteLine(String.Format("Time: {0}", CurrentTime));

                w.WriteLine();

                w.Flush();
                w.Close();
            }
            catch // if any error happened, send email
            {
                try 
                {
                    Email_BLL emailBll = new Email_BLL();
                    emailBll.Send("Error From Website: " + ConfigurationManager.AppSettings["SiteName"],
                                  ConfigurationManager.AppSettings["LogTechnicalemail"], "Error From Website: " + ConfigurationManager.AppSettings["WebsiteUrl"]
                                                                                         + "<br />Error Details: " + exception.Message
                                                                                         + "<br /> Layer Is: " + Layer
                                                                                         + "<br /> Class Name: " + ClassName
                                                                                         );
                }
                catch // if any error happened, send sms
                {
                    try
                    {
                        string smsBody = String.Format("Error on {0}:{1},{2}", ConfigurationManager.AppSettings["SiteName"].TrimEnd(' '), exception.Message, ClassName);
                        if (smsBody.Length > 160)
                            smsBody = smsBody.Substring(0, 159);

                        SMS_BLL smsBll = new SMS_BLL();
                        smsBll.Send(ConfigurationManager.AppSettings["LogTechnicalPhone"], smsBody );
                    }
                    catch 
                    {
                        // dont do any thing, just Say LOL
                    }
                }

            }
        }
    }
}
