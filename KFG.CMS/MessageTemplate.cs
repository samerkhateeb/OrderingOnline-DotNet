using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFGCMS.BLL
{
    public class MessageTemplate
    {

        public static string sms1
        {
            get
            {
                return "Thank You for ordering from {0}. Your order number is:  {1}. For further assistance please call our hotline 186 16 16";

            }
        }

        public static string sms2
        {
            get
            {
                return "Welcome to {0} website, your authorization code is: {1}";

            }
        }

        public static string email1
        {
            get
            {
                return "<b>Welcome to {0} website.</b> <br /> your authorization Code is:{1}.";

            }
        }


        public static string email2
        {
            get
            {
                return "<strong>Thank You for ordering from {0}. Your order number is:  {1}. A confirmation SMS has been sent to your mobile number: {2} </strong><br />For further assistance please call our hotline 186 16 16";

            }
        }

        public static string email3
        {
            get
            {
                return "you have received following order from shopping.com: <br /> WebOrder #: {0}<br /> Customer Name: {1} <br /> Customer Telephone: {2} <br /> Total Order Value: {3} KD";

            }
        }







    }
}
