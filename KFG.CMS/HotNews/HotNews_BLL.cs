using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KFGCMS.BLL
{
   public class HotNews_BLL
    {

       static string active = "";
        /// <summary>
        /// Init Hot News JavaScript
        /// </summary>
        /// <param name="NewsDataTable"></param>
        /// <returns></returns>
        public static List<string> HotNews_Generator(DataTable NewsDataTable)
        {
            int count = 0;
            StringBuilder ItemsStringBuilder = new StringBuilder(),
                    ulStringBuilder = new StringBuilder();
            count = NewsDataTable.Rows.Count;
            foreach (DataRow row in NewsDataTable.Rows)
            {
                ItemsStringBuilder.Append(
                    String.Format(@"<LI><a href='{1}'><img alt='{0}'src='{2}' ></a>
                                <div class='HotNewsContent_TextBG'></div>
                                <div class='HotNewsContent_TextContainer'>
                                    <div class='HotNewsContent_TextDiv Direction'>
                                        <a href='{1}' class='HotNewsContent_TextLink'>{0}</a>
                                        <a href='{1}' class='HotNewsContent_DescriptionText'>{3}</a>
                                    </div>
                                </div>", row["Title"], GetEncodedLink(row), Global_BLL.ResolveImagePath(row["Thumbnail"]), row["HotNews_Description"] ));

                ulStringBuilder.Append(String.Format(@"<LI><A class='slide{0}{1}' href='javascript:void(0)'>{0}</A></LI>",
                    count, active));
                active = "";
                count--;

            }
            List<string> NewsResult = new List<string>();

            NewsResult.Add(ItemsStringBuilder.ToString());
            NewsResult.Add(ulStringBuilder.ToString());
            return NewsResult;
        }

        private static object GetEncodedLink(DataRow row)
        {
            if (row["Source"].ToString().ToLower() == "subpage")
                return Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]);
            else
                //  if (row["Source"].ToString().ToLower() == "category")
                return Pages_BLL.GenerateUrl(row["ID"], "category", row["Type"], row["StaticLink"]);
            //else
            //    // if (row["Source"].ToString().ToLower() == "category")
            //    return row["RoottEncodedLink"];

        }

//        /// Init Hot News JavaScript
//        /// </summary>
//        /// <param name="NewsDataTable"></param>
//        /// <returns></returns>
//        public static string HotNews_Generator(DataTable NewsDataTable)
//        {
//            int count = 0;
//            StringBuilder LeftImageStringBuilder = new StringBuilder(),
//                            LeftTextStringBuilder = new StringBuilder(),
//                            RightStringBuilder = new StringBuilder(),
//                            TextStringBuilder = new StringBuilder();

//            count = NewsDataTable.Rows.Count;

//            string HotNews_Template = @"<DIV id=ifocus>
//                                       {0}{1}{2}</div>",

//                    HotNews_TemplateLeft = @"<DIV id=ifocus_pic>
//                                            <DIV id=ifocus_piclist>
//                                                <UL>{0}</ul>
//                                            </div>
//                                        <DIV id=ifocus_opdiv></DIV>
//                                            <DIV id=ifocus_tx><UL>{1}</ul></div>
//                                        </div>",

//                    HotNews_TemplateRight = @"<DIV id=ifocus_btn><UL>{0}</ul></div>",
//                    HotNews_TextTemplate = "<div class='TextDiv'>{0}</div>",

//            HotNews_Left = "", HotNews_Right = "";


//            foreach (DataRow row in NewsDataTable.Rows)
//            {

//                LeftImageStringBuilder.Append(String.Format(@" <LI>
//   	                                                <A href='{0}' >
//     			                                            <IMG border=0 src='{1}' width=480 height=330>
//                                                    </A>
//                                                </LI>", Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]),
//                                                        Global_BLL.ResolveImagePath(row["Thumbnail"])));




//                LeftTextStringBuilder.Append(String.Format(@"   <LI class=normal><a class='ifocus_LinkButton' href='{2}'>{0}</a>
//                                                                <div class='ifocus_Description'>{1}</div></LI>",
//                                            row["Title"], Pages_BLL.FilterDescriptionText(row["Description"], 120), Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"])));


//                RightStringBuilder.Append(String.Format(@"<LI class=current><A 
//                                                          onmouseover='document.getElementById('bResim').src='{0}';' 
//                                                          href='{1}' >
// 
//                                                          <IMG class='Item_Right_Image'  id=hbrImage name=hbrImage alt='{3}' src='{2}'>
//                                                           
//                                                           
//                                                          </A>",
//                                                               Global_BLL.ResolveImagePath(row["Thumbnail"]),
//                                                               Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]),
//                                                               Global_BLL.FilterImagePathToThumbnail(row["Thumbnail"]),
//                                                               row["Title"]));

//                TextStringBuilder.Append(String.Format(@"<div class='Item_Right_Text FloatRight'>{0}</div>", row["Title"]));

//            }

//            HotNews_Left = String.Format(HotNews_TemplateLeft, LeftImageStringBuilder.ToString(), LeftTextStringBuilder.ToString());

//            HotNews_Right = String.Format(HotNews_TemplateRight, RightStringBuilder);

//            HotNews_TextTemplate = String.Format(HotNews_TextTemplate, TextStringBuilder.ToString());

//            return (String.Format(HotNews_Template, HotNews_Left, HotNews_Right, HotNews_TextTemplate));

//        }

       

    }
}
