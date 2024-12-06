using ATM_clone.Entities;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.App_Program
{
    internal class Validator
    {
        public static bool AccountValidator (string accountPIN, string accountPassword, Dictionary <Account,User> Accouunts )
        {

            
            if (accountPIN == null) { return false; }
            Account testAccount = new Account (accountPassword,accountPIN ) ;
            Console.WriteLine();
            foreach (var item in Accouunts)
            {
                
                if (item.Key.PIN == testAccount.PIN && item.Key.Password== testAccount.Password)
                {
                    return true;
                }
            }           

            return false;
        }
        // return owner of the account
        public static User getUser(string accountPIN, string accountPassword)
        {
            return DB.data.FirstOrDefault(entry => entry.Key.PIN == accountPIN && entry.Key.Password == accountPassword).Value; 
        }
    }
}
