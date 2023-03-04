using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KFGCMS.BLL
{
    public class FileUpload_Info
    {
        public static string[] Extensions
        {
             get
                {
                    Regex regex = new Regex(" ");
                    string[] arrayString = regex.Split(".doc .docx .pdf");
                    Array.Sort(arrayString);
                    return arrayString;
                }
        }


        public static long Size
        {
            get
            {
                return 300000; // 300 KB
            }
        }


        public static string CV_Folder
        {
            get
            {
                return "~/Portals/Career_Files/";
            }
        }


        public static string ErrorMessage
        {
            set;
            get;
        }



    }
}
