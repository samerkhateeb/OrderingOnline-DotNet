using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFGCMS.Utilities
{
    public class Url
    {
        #region Members
            static string strKey = "KFGKeyEncodedSecurityTechnique";
            static int KeyLenght = strKey.Length;
        #endregion

        public static string EncodeUrl(string Url)
        {
            string encodedString = Url;

            Random random = new Random(3);
            int num = Convert.ToInt32((KeyLenght * random.Next(0, 3)) + 1);

            for (int i = 1; i <= num; i++)
                encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);

            char[] Seed_Array = strKey.ToCharArray();
            encodedString = String.Format("{0}+{1}", encodedString, Seed_Array[num]);

            encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);
            return encodedString;
        }

        public static string DecodeUrl(object decodeOriginalObject)
        {

            char[] Seed_Array = strKey.ToCharArray();
            string decodeOriginalString = decodeOriginalObject.ToString().Split('.')[0];
            string strDecode = ConvertBytesToString(Convert.FromBase64String(decodeOriginalString));
            char letter = Convert.ToChar(strDecode.Split('+')[1]);
            strDecode = strDecode.Split('+')[0];

            int i = 0;
            for (i = 0; i < Seed_Array.Length; i++)
                if (Seed_Array[i] == letter)
                    break;

            for (int j = 0; j < i; j++)
                strDecode = ConvertBytesToString(Convert.FromBase64String(strDecode));

            return strDecode;
        }


        private static byte[] ConvertStringToByte(string original)
        {
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            return ascii.GetBytes(original.ToCharArray());
        }

        private static string ConvertBytesToString(Byte[] encoded)
        {
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            return new String(ascii.GetChars(encoded));
        }

        
    }
}
