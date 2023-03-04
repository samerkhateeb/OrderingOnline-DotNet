using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KFGCMS.BLL
{
    public class Courses_Info
    {

        private static string _VendorID;
        public static string VendorID
        {
            
            get
            {
                ////imore 
                //return "1362798";
                // Dar Alhamd return "1258236";

                 //Test
               return "1303908";
            }
        }


        /// <summary>
        /// to return back to our website after 2checkout payment complete
        /// </summary>
        public static string ReturnUrl
        {
            get
            {
                return "http://localhost/daralhamd/Portals/CoursesAuthorizePayment";
            }
        }



        public static string DemoLink
        {
            get
            {
                return "&demo=Y&";
            }
        }

        public static string CompleteQString
        {
            set;
            get;

        }

        /// <summary>
        /// Secret Word
        /// </summary>
        public static string SecretWord
        {
            get
            {
                return "Al-H3Rd~-#f4DPE@";
            }
        }


        public string UserID
        {
            set;
            get;
        }




        public string UserName
        {
            set;
            get;
        }

        public string UserEmail
        {
            set;
            get;
        }


    }
}
