using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinSMSer.Utils
{
    public static class SmsUtils
    {
        public static bool validatePhoneNumer(string phoneNumber)
        {
            Regex reg = new Regex(@"^[\d]{9}$", RegexOptions.IgnoreCase);
            Match m = reg.Match(phoneNumber);

            return m.Success;
        }
    }
}
