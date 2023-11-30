using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Manager
{
    internal class Functions
    {
        public static bool CheckNull(List<string> args) 
        {
            if (args.Any(tb => string.IsNullOrWhiteSpace(tb)))
            {
                MessageBox.Show("Required entry is empty.");
                return false;
            }
            return true;
        }
        public static bool CheckMin(List<string> args, int length)
        {
            if (args.Any(tb => tb.Count() < length))
            {
                MessageBox.Show($"Entry less than {length}.");
                return false;
            }
            return true;
        }
    }
}
