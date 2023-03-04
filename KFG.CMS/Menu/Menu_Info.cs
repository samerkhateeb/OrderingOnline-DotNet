using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KFGCMS.BLL
{
   public class Menu_Info
    {
       public string Type
       {
           set;
           get;
       }

       public DataTable ParentDataSource
       {
           set;
           get;
       }

       public DataTable ChildDataSource
       {
           set;
           get;
       }

       public static string CurrentPageID { get; set; }
    }
}
