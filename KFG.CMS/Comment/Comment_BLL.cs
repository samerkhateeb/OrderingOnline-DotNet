using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KFGCMS.BLL;

namespace KFGCMS.BLL
{
 public   class Comment_BLL
    {

        public static int Comment_Insert()
        {




            return Comment_DAL.Comment_Insert(Comment_Info.SourceID,
                Comment_Info.CommentName,
                Comment_Info.CommentEmail, 
                Comment_Info.CommentDetails, 
                Comment_Info.SourceName,
                Comment_Info.CommentDate,
                Pages_BLL.GetLanguage());
        }




    }
}
