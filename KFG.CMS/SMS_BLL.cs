using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KFGCMS.BLL.ZainMessenger;
using KFGCMS.Utilities;
namespace KFGCMS.BLL
{
    public class SMS_BLL
    {

    #region Memebers
        string  Zain_username = "kfg",
                Zain_password = "mpp",
                Zain_originator = "KFG",
                Zain_CustomerID = "44502",
                Zain_APIURL = "http://bms.kw.zain.com/bms/soap/messenger.asmx",
                

                Watania_APIURL = "http://208.43.76.66/api",
                Watania_UserName = "homaizi-wat",
                Watania_Password = "kuwait",

                VIVA_APIURL = "http://208.43.76.66/api",
                VIVA_UserName = "homaizi-viva",
                VIVA_Password = "kuwait";
	#endregion

        public int Send(string Telephone, string Body)
        {
            try
            {

                string Operater = Telephone.Substring(0, 1),
                    url = "", response = "",
                    smsData = Body,
                    cTelephone = "965" + Telephone;

                if (Operater == "9")
                {

                    Messenger messenger = new Messenger();
                    messenger.Timeout = 4294967;

                    SoapUser user = new SoapUser();
                    user.CustomerID = 44502;
                    user.Name = Zain_username;
                    user.Language = "en";
                    user.Password = Zain_password;
                    
                    string defDate = DateTime.UtcNow.ToString("yyyyMMddhhmmss");

                    SendResult result = messenger.SendSms(user, Zain_originator, smsData, cTelephone, MessageType.Latin, defDate, false, false, false);



//                    url = String.Format(@"{0}/HTTP_SendSms?customerID={1}&userName={2}&userPassword={3}&originator={4}
//                            &smsText={5}&recipientPhone={6}&messageType=0&defDate=&blink=false&flash=false&Private=false",
//                            Zain_APIURL, Zain_CustomerID, Zain_username, Zain_password, Zain_originator, Body, cTelephone);

//                    response = KFGResponse.GetResponseAsString(url, 2147483647);


                    response = "ok";



                }

                else
                    if (Operater == "6") // Watania
                    {
                        url = String.Format("{0}/send.aspx?username={1}&password={2}&language=2&sender=KFG&mobile={3}&message={4}",
                                            Watania_APIURL, Watania_UserName, Watania_Password, cTelephone, Body);
                        response =   KFGResponse.GetResponseAsString(url, 2147483647);
                    }
                    else
                        if (Operater == "5") // VIVA
                        {
                            url = String.Format("{0}/send.aspx?username={1}&password={2}&language=2&sender=KFG&mobile={3}&message={4}",
                                        VIVA_APIURL, VIVA_UserName, VIVA_Password, cTelephone, Body);
                            response = KFGResponse.GetResponseAsString(url, 2147483647);
                        }

                if (!String.IsNullOrEmpty(response) && response.Substring(0, 2).ToLower() == "ok")
                {
                    return 1;
                }
                else
                    return 0;

            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal-BLL", this.GetType().Name);
                return 0;
            }
        }
    }
}
