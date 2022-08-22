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
        public static string EMAIL_REGEX_PATTERN = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILE_REGEX_PATTERN = "^[91]{2}[' ']{1}[7898625487]{10}$";
        public static string PASS_REGEX_PATTERN = "^[A-Za-z]{8,}";

       

        public bool FNameValidation(string Firstname) => Regex.IsMatch(Firstname, REGEX_PATTERN) ? true : throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME,"First name is invalid");
        public bool LNameValidation(string Lastname) => Regex.IsMatch(Lastname, REGEX_PATTERN) ? true : throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Last name is invalid");

        public bool EmailValidation(string Email) => Regex.IsMatch(Email, EMAIL_REGEX_PATTERN) ? true : throw new UserException(UserException.ExceptionType.INVALID_EMAIL, "Email is invalid");
        public bool MobileValidation(string Mobile) => Regex.IsMatch(Mobile, MOBILE_REGEX_PATTERN) ? true : throw new UserException(UserException.ExceptionType.INVALID_MOBILENUMBER, "Mobile number is invalid");
        public bool PassValidation(string Password) => Regex.IsMatch(Password, PASS_REGEX_PATTERN) ? true : throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Password is invalid");
    }
}
