using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace KFGCMS.Utilities
{
    public class KFGResponse
    {

        public static string GetResponseAsString(string url, int timeout)
        {
            HttpWebRequest webRequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            webRequest.AllowAutoRedirect = true;
            webRequest.Timeout = 1000 * 30;
            webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";
            webRequest.PreAuthenticate = true;
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            // webRequest.Proxy = new System.Net.WebProxy("your proxy server", true); // comment out if you're not going thru a proxy

            WebResponse webResponse = null;

            try
            {
                webResponse = webRequest.GetResponse();
                Stream stream = webResponse.GetResponseStream();
                Encoding encoding = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader streamReader = new StreamReader(stream, encoding);
                string result = streamReader.ReadToEnd();
                return result;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private static HttpWebResponse GetResponse(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)System.Net.WebRequest.Create(url);
            // webRequest.Proxy = new System.Net.WebProxy("your proxy server", true); // comment out if you're not going thru a proxy
            webRequest.AllowAutoRedirect = true;
            webRequest.Timeout = 1000 * 30;
            webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";
            webRequest.PreAuthenticate = true;
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            return (HttpWebResponse)webRequest.GetResponse();
        }




    }
}
