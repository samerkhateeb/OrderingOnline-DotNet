using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KFGCMS.Utilities
{
    public class Security
    {
        static string injectionPattern = "['\"]";

        public static string ExcludeInjection(string inputString)
        {
            return ExcludeInjection(inputString, injectionPattern);
        }

        public static string ExcludeInjection(string inputString, string Pattern)
        {
            Regex reg = new Regex(injectionPattern);
            return reg.Replace(inputString, "");
        }


    }
}
