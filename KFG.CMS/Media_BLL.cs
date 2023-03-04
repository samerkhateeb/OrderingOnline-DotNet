using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace KFGCMS.BLL
{
    public class Media_BLL
    {

        public static string ProcessImage(object imagePath)
        {
            string AssetsMainFolder = ConfigurationManager.AppSettings["AssetsMainFolder"].ToString(),
                   GeneralFolder = ConfigurationManager.AppSettings["GeneralFolder"].ToString(),
                   emptyImage = "", fileName = "", NameJust = "", extension = "", DirectoryName = "";

            try
            {

                emptyImage = "/Assets" + ConfigurationManager.AppSettings["EmptyThumbnailImage"].ToString();
                fileName = imagePath.ToString();
                NameJust = Path.GetFileNameWithoutExtension(fileName);
                extension = Path.GetExtension(fileName);
                DirectoryName = Path.GetDirectoryName(fileName);

                if (fileName != "" && NameJust != "" && extension != "")
                    return AssetsMainFolder + "/" + GeneralFolder + DirectoryName + "/" + NameJust + extension;
                else
                    return emptyImage;

            }
            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().ReflectedType.Name);
                return emptyImage;
            }

        }




    }
}