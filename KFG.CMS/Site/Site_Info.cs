using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web.UI.WebControls;

namespace KFGCMS.BLL
{
    public class Site_Info
    {
        private static string _CurrentLanguage;

        public static string CurrentLanguage
        {
            set
            {
                _CurrentLanguage = value;
            }

            get
            {
                //if (!String.IsNullOrEmpty(_CurrentLanguage))
                    return Pages_BLL.GetLanguage();
                //else
                //    return _CurrentLanguage;
            }
        }




        public static string SearchText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "إبحث";
                }
                else
                    return "Search";

            }
        }



        public static string SearchResultEmptyText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "لا يوجد نتائج مطابقة لبحثك ... يرجى المحاولة مرة أخرى";
                }
                else
                    return "<br /><CENTER><b>There is no results mach your request! please try again...</b></CENTER>";

            }
        }

        public static string SearchResultHeader
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "نتيجة البحث";
                }
                else
                    return "Search Result";

            }
        }




        public static string SearchWaterMarkText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "للبحث داخل الموقع";
                }
                else
                    return "Search in Site";

            }
        }

        public static string CommentResultText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "شكرا لتواصلكم معنا";
                }
                else
                    return "Comment Successfully Sent, Thanks for your Time";

            }
        }



        public static string CopyRightText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "جميع الحقوق محفوظة";
                }
                else
                    return "All Rights Reserved for InterPal.Org";

            }
        }


        public static string TopMenu_Language
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "English";
                }
                else
                     return "عربي";

            }
        }

        public static string TopMenu_Logout
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الخروج";
                else
                    return "Logout";

            }
        }

        public static string TopMenu_Login
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "دخول الأعضاء";
                else
                    return "Login";

            }
        }

        public static string TopMenu_Home
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الرئيسية";
                else
                    return "Home";

            }
        }
        public static string TopMenu_CotnactUs
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "إتصل بنا";
                else
                    return "Contact Us";

            }
        }
        public static string TopMenu_SiteMap
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "خريطة الموقع";
                else
                    return "Site Map";

            }
        }
        public static string TopMenu_Careers
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الوظائف";
                else
                    return "Careers";

            }
        }

        public static string SPGroupsTitleText
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "المواضيع المتعلقة";
                }
                else
                {
                    return "Related Items";
                }
            }
        }


        public static string CommentTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "نموذج التعليق";
                }
                else
                {
                    return "Comments Form :";
                }
            }
        }

        public static string CommentName
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "الإسم: ";
                }
                else
                {
                    return "Name :";
                }
            }
        }

        public static string CommentEmail
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "البريد الإلكتروني :";
                }
                else
                {
                    return "Email :";
                }
            }
        }
        
        public static string CommentContent
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "الملاحظة :";
                }
                else
                {
                    return "Comment :";
                }
            }
        }


        public static string Questionnaire_Header
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "الإستفتاءات /";
                }
                else
                {
                    return "Questionnaires \\ ";
                }
            }

        }



        public static string QuestionnaireResultLabel
        {
            get
            {
                if (CurrentLanguage == "arb")
                {
                    return "نشكرك للمشاركة في الإستفتاء";
                }
                else
                {
                    return "Thank you For Filling the questionnaire";
                }
            }

        }


        public static string QuestionnaireGridViewEmptyText
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الاستفتاء المختار غير متاح حالياُ، يرجى المحاولة لاحقا..";
                else
                    return "The Selected Questionnaire is not Available Right Now !!";
            }
        }


        public static string SignUpUserExist
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الإسم الذي أدخلته مستخدم سابقاُ، يرجى إختيار اسم آخر";
                else
                    return "the user name is already used by another user, please try another one.";
            }
        }



        public static string EmailTooTip
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "إرسال";
                else
                    return "Send";
            }
        }


        public static string EmailSubject
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return ConfigurationManager.AppSettings["SiteName"].ToString() + "يرحب بكم";
                else
                    return ConfigurationManager.AppSettings["SiteName"].ToString() + " ... Registration Notice";
            }
        }


        public static string EmailNotification
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return ConfigurationManager.AppSettings["SiteName"].ToString() + "لإكمال عملية التسجيل {0}";
                else
                    return ConfigurationManager.AppSettings["SiteName"].ToString() + "thank you for your registration, please {0} to complete registration process";
            }
        }


        public static string SignUp_Complete
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "تمت عملية التسجيل بنجاح";
                else
                    return "Your Sign Up Completed successfully ... thank you";
            }
        }

       
        public static string ForgetPassword_Header
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "استعادة كلمة المرور";
                else
                    return "Forget Password?";
            }
        }

        public static string ForgetPassword_Label
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الرجاء إدخال بريدك الإلكتروني";
                else
                    return "Please Enter Your Email";
            }
        }


        public static string ForgetPassword_Success
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return " تم إرسال البريد بنجاح، يرجى مراجعة بريدك الإلكتروني لمعاينة كلمة المرور";
                else
                    return "Password Successfully Sent to Your Email...";
            }
        }



        public static string ForgetPassword_SubjectEmail
        {
               get
               {
                if (CurrentLanguage == "arb")
                    return "استرجاع كلمة المرور";
                else
                    return "Account Password Request";
               }
        }


        public static string Careers_Header
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "نموذج التوظيف";
                else
                    return "Careers Form";
            }
        }


        public static string Careers_Name
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الإسم:";
                else
                    return "Name:";
            }
        }


        public static string Careers_Email
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "البريد الإلكتروني:";
                else
                    return "Email:";
            }
        }


        public static string Careers_Phone
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "رقم الهاتف:";
                else
                    return "Phone:";
            }
        }

        public static string Careers_Specialist
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "التخصص:";
                else
                    return "Specialization:";
            }
        }

        public static string Careers_Country
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "البلد:";
                else
                    return "Country:";
            }
        }

        public static string Careers_ExperienceYears
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "سنوات الخبرة:";
                else
                    return "Experience Years:";
            }
        }

        public static string Careers_PMPHolder
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "تحمل شهادة معتمدة لإدارة المشاريع:";
                else
                    return "PMP Holder:";
            }
        }

         public static string Careers_ThanksLabel
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "تم إرسال طلبك، شكرا لتواصلكم معنا";
                else
                    return "Your Request Successfully Sent, Thanks for your time";
            }
        }



        public static string LoginForm_Header
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "نموذج الدخول";
                else
                    return "Login Form";
            }
        }


        public static string SignUp_Complete_PageTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "اكمال عملية التسجيل";
                else
                    return "Complete Registration Process";
            }
        }

        public static string ForgetPassword_Fail
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "البريد الذي أدخلته غير موجود لدينا، يرجى تجربة بريد آخر.";
                else
                    return "The email does not exist in our DataBase, please try another email";
            }
        }

        public static string SignUp_Complete_SuccessMessage
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "تمت عملية التسجيل بنجاح";
                else
                    return "Registration Process Completed Successfully";
            }
        }

        public static string Signup_Header
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "نموذج التسجيل";
                else
                    return "Signup Form";
            }
        }


        public static string Signup_Name
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الإسم كاملاً:";
                else
                    return "Name:";
            }
        }

        public static string Signup_Password
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "كلمة المرور:";
                else
                    return "Password:";
            }
        }

        public static string Signup_PasswordConfirm
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "تأكيد كلمة المرور:";
                else
                    return "Confirm Password:";
            }
        }

        public static string Signup_Email
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "البريد الإلكتروني:";
                else
                    return "Email:";
            }
        }

        public static string Signup_Phone
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "رقم الهاتف:";
                else
                    return "Phone Number:";
            }
        }

        public static string Signup_Comments
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "ملاحظات واستفسارات:";
                else
                    return "Comments:";
            }
        }

        public static string Signup_Pending_Error
        {
            get
            {  
                if (CurrentLanguage == "arb")
                    return "حدث خطأ في إرسال الإيميل اللازم لإكمال عملية التسجيل، يرجى التأكد من صحة البريد الإلكتروني أو المحاولة بعد قليل";
                else
                    return "An error occured while sending required registration email, please make sure that you are Typing your email correctly or try again later.";
            }
        }

        public static string Signup_Pending_Successfull
        {
            get
            {  
                if (CurrentLanguage == "arb")
                    return "تمت المرحلة الأولى من التسجيل بنجاح، يرجى مراجعة بريدك الإلكتروني لإكمال عملية التسجيل";
                else
                    return "Thanks For Registration, please check your e-mail in-box to complete your registration";
            }
        }

        public static string Signup_Pending_Click
        {
            get
            {  
                if (CurrentLanguage == "arb")
                    return "إضغط هنا";
                else
                    return "Click Here";
            }
        }

        public static string Signup_PageTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "صفحة التسجيل";
                else
                    return "Signup Page";
            }
        }


        public static string Login_PageTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "صفحة الدخول";
                else
                    return "Login Page";
            }
        }


        /*****************************
         * Contact US
         ****************************/

        public static string ContactUs_HeaderTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "نموذج الاتصال*";
                else
                    return "";
            }
        }


        public static string ContactUs_Name
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الإسم:*";
                else
                    return "Full Name:*";
            }
        }


        public static string ContactUs_Email
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "البريد الإلكتروني: *";
                else
                    return "Email: *";
            }
        }

        public static string ContactUs_Department
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "القسم:";
                else
                    return "Department:";
            }
        }

        public static string ContactUs_Message
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الرسالة: *";
                else
                    return "Message: *";
            }
        }

        public static List<ListItem> ContactUs_DepartmentsList
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return new List<ListItem>{new ListItem("-- إختر القسم --"), new ListItem("الهيئة الادارية"), new ListItem("الدعم الفني"), new ListItem("قسم التعليقات")};
                else
                    return new List<ListItem> { new ListItem("-- Choose Department --"), new ListItem("Management"), new ListItem("Technical Support") };
            }
        }

        public static string ContactUs_SendButton
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "أرسل الرسالة";
                else
                    return "Send Message";
            }
        }

        public static string ContactUs_EmailTitle
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "الاتصال مع الموقع الالكتروني";
                else
                    return "Contact With Our Website";
            }
        }

        public static string ContactUs_ValidationName
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "يرجى إدخال الإسم";
                else
                    return "Name Required";
            }
        }


        public static string ContactUs_ValidationEmail
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "يرجى ادخال البريد الإلكتروني بشكل صحيح";
                else
                    return "Please Enter Your Email Correctly";
            }
        }

        
        public static string ContactUs_ValidationMessage
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "يرجى ادخال الرسالة";
                else
                    return "Message Required";
            }
        }




        /*****************************
         * Contact US
         ****************************/






        public static string PrintTooTip
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "طباعة";
                else
                    return "Print";
            
            }
        }

        public static string EmailSentSuccessfully
        {
            get
            { 
              if (CurrentLanguage == "arb")
                    return "تم الارسال بنجاح";
                else
                    return "Email Sent Successfully..";
            
            }
        }

        public static string ReadMore
        {
            get
            {
                if (CurrentLanguage == "arb")
                    return "إقرأ أيضاُ: ";
                else
                    return "Read More: ";
            }
        }



        public static string MediaTextLabel
        {
            get
            { 
                if (CurrentLanguage == "arb")
                    return "ملاحظة: عند الضغط على زر التشغيل، يرجى الانتظار قليلاً";
                else
                    return "Note: when you click on play button, please wait a moment for buffering ";
            }
            
        }
    }
}
