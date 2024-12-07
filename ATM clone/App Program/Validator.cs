using ATM_clone.Entities;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.App_Program
{
    internal static class Validator
    {
        public static bool AccountValidator(string accountPIN, string accountPassword, Dictionary<Account, User> Accounts)
        {
            // التحقق من أن المدخلات ليست فارغة أو null
            if (string.IsNullOrEmpty(accountPIN) || string.IsNullOrEmpty(accountPassword))
            {
                return false;
            }

            // is data type is true
            if (!IsTypeMatch<int>(accountPIN, accountPassword))
            {
                return false ;
            }

            // chech if the account is created or no
            return Accounts.Any(item => item.Key.PIN == accountPIN && item.Key.Password == accountPassword);
        }

        public static bool IsTypeMatch<T>(this string input,string input2="",string input3="")
        {
            try
            {
                T result = (T)Convert.ChangeType(input, typeof(T));
                return true; 
            }
            catch
            {
                return false; 
            }
        }


    }
}
