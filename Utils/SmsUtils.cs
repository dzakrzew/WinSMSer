using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinSMSer.Utils
{
    /// <summary>
    /// Zbiór statycznych funkcji pomocniczych do procesowania wiadomości SMS
    /// </summary>
    public static class SmsUtils
    {
        /// <summary>
        /// Walidacja podanego numeru telefonu
        /// </summary>
        public static bool validatePhoneNumer(string phoneNumber)
        {
            Regex reg = new Regex(@"^[\d]{9}$", RegexOptions.IgnoreCase);
            Match m = reg.Match(phoneNumber);

            return m.Success;
        }
    }
}
