using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace KFGCMS.BLL
{
    public class FileUpload_BLL
    {
        public string SaveAs(HttpPostedFile PostedFile)
        {
            string fileName = PostedFile.FileName,
                    fileExtension = Path.GetExtension(PostedFile.FileName),
                    fileNameJust = Path.GetFileNameWithoutExtension(PostedFile.FileName),
                    staticPath = HttpContext.Current.Server.MapPath(FileUpload_Info.CV_Folder);
            try
            {
                FileInfo fileInfo = new FileInfo(staticPath + "/" + fileName);

                //if (fileInfo.Length > FileUpload_Info.Size) // Check File Size
                //{
                //    FileUpload_Info.ErrorMessage = "The File Size is Maximum than Available";
                //    return "Error";
                //}

                //else // File Extension is not available
                    if (Array.BinarySearch(FileUpload_Info.Extensions, fileExtension.ToLower()) < 0)
                    {
                        FileUpload_Info.ErrorMessage = "Not Valid Extension";
                        return "Error";
                    }

                    else
                    {

                        byte[] arrData = new byte[2049];

                        if (fileInfo.Exists)
                            while (fileInfo.Exists)
                            {
                                fileNameJust += "_Ren";
                                fileInfo = new FileInfo(staticPath + fileNameJust + fileExtension);
                            }


                        fileName = fileNameJust + fileExtension;
                        // init stream values
                        Stream OutStream = new FileStream(staticPath + fileName, FileMode.Create, FileAccess.Write),
                                InStream = PostedFile.InputStream;


                        int length = InStream.Read(arrData, 0, arrData.Length);
                        while (length > 0)
                        {
                            if (OutStream != null)
                            {
                                OutStream.Write(arrData, 0, length);
                            }

                            length = InStream.Read(arrData, 0, arrData.Length);
                        }

                        OutStream.Seek(0, SeekOrigin.Begin);

                        // clost stream files
                        InStream.Close();
                        OutStream.Close();


                        return fileName;

                    }
            }


            catch (Exception ex)
            {
                return "Error";
            }
        }
    }



    
}
