using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace KFGCMS.BLL
{
    public class CookieManager
    {

        public bool ClearOrderCookies()
        {
            try
            {

                 HttpCookie OrderTypeCookie = HttpContext.Current.Request.Cookies["OrderType"],
                            TotalCookie = HttpContext.Current.Request.Cookies["total"],
                            GeneralNote = HttpContext.Current.Request.Cookies["GeneralNote"];


                if (OrderTypeCookie != null)
                {
                    HttpContext.Current.Request.Cookies["OrderType"].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["OrderType"]);    
                }

                if (TotalCookie != null)
                {
                    HttpContext.Current.Request.Cookies["total"].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["total"]);                    
                }

                if (GeneralNote != null)
                {
                    HttpContext.Current.Request.Cookies["GeneralNote"].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["GeneralNote"]);
                }
                
             

                int i = 0;
                while (HttpContext.Current.Request.Cookies["ItemID" + i] != null)
                {
                    HttpContext.Current.Request.Cookies["ItemID" + i].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["ItemID" + i]);

                    HttpContext.Current.Request.Cookies["Price" + i].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["Price" + i]);

                    HttpContext.Current.Request.Cookies["Quantity" + i].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["Quantity" + i]);

                    HttpContext.Current.Request.Cookies["ItemName" + i].Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(HttpContext.Current.Request.Cookies["ItemName" + i]);
                    i++;
                }

                return true;
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return false;
            }
        }

        public bool ClearUserCookies()
        {
            try
            {
                HttpCookie userCookie = HttpContext.Current.Request.Cookies["CustomerInfo"];

                if (userCookie != null)
                {
                    userCookie.Expires = DateTime.Now;
                    HttpContext.Current.Response.Cookies.Add(userCookie);
                    return true;
                }
                else
                    return false;

                
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return false;
            }
        }




    }
}
