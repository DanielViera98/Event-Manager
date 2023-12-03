using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Event_Manager
{
    internal class Functions
    {
        public static bool CheckNull(List<string> args)
        {
            if (args.Any(tb => string.IsNullOrWhiteSpace(tb)))
                return false;
            return true;
        }
        public static bool CheckMin(List<string> args, int length)
        {
            if (args.Any(tb => tb.Count() < length))
                return false;
            return true;
        }
        public static bool CheckContains(List<string> args, char[] testFor)
        {
            if (args.Any(tb => tb.IndexOfAny(testFor) >= 0))
                return true;
            return false;
        }
        public static bool CheckEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);

        }
        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        public static bool CheckPhone(string number)
        {

            if (number != null) return Regex.IsMatch(number, motif);
            else return false;

        }

        public static bool CheckString(string entry)
        {

            if (!string.IsNullOrWhiteSpace(entry)) return true;
            else return false;

        }

        public static bool CheckUsernameFree(string username)
        {
            var db = new EventContext();
            if (db.Accounts.Any(p=>p.UserName == username)) {
                MessageBox.Show($"username '{username}' is already taken.");
                return false;
            }
            return true;
        }
    }
}
