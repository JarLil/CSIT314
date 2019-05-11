using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace Group13
{
    public static class FieldChecks
    {

        public static Boolean CheckPicker(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string CheckEmoji(string value)
        {
            if (value != null)
            {
                string result = Regex.Replace(value, @"\p{Cs}", "");

                return result;
            }
            else
            {
                return value;
            }
        }

        public static Boolean checkEmail(string value)
        {
            try
            {
                MailAddress mail = new MailAddress(value);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error", e);
                return false;
            }

        }

        public static Boolean CheckPassword(String value)
        {
            Regex Check = new Regex("^[a-zA-Z]{4,20}$");

            if (value == "" || value != null)
            {
                return (Check.IsMatch(value));
            }
            else
            {
                return false;
            }
        }

        public static Boolean isNotNull(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
