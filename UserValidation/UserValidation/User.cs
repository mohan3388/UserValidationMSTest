using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserValidation
{
    public class User
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool FNameValidation(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }
}
