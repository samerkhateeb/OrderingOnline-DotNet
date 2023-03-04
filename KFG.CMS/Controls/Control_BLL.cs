using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KFGCMS.BLL
{
    public class Control_BLL
    {
        public static DataSet ControlSelect(string controlID, string language)
        {
            if (String.IsNullOrEmpty(language))
                language = Pages_BLL.GetLanguage();

            return Control_DAL.ControlSelect(controlID, language);
        }
    }
}
