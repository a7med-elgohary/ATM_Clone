using ATM_clone.App_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace ATM_clone.Entities
{
    internal class User
    {
        public  Account? Account { get; set; }
        public  string?FristName { get; set; }
        public  string?LastName { get; set; }
        public string? fulName { get; set; }
        
        
        
    
    public static void Balance_Inquiry(Account account)
        {
            Console.WriteLine($"youre balance = {account.Balance}");
        }


        internal static void cash_Deposit(Account account)
        {
            string theinput = Utilty.GetInput($" how much you want to Deposit it >> ");
            bool issucsess = Validator.IsTypeMatch<uint>(theinput);
            if (issucsess)
            {
                account.Balance -= uint.Parse(theinput);
                Balance_Inquiry(account);
            }
        }

        internal static void cashWithdrawal(Account account)
        {
            string theinput = Utilty.GetInput($" how much you want to draeal it >> ");
            bool issucsess = Validator.IsTypeMatch<uint>(theinput);
            if (issucsess)
            {
                account.Balance += uint.Parse(theinput);
                Balance_Inquiry(account);
            }
        }
    }
}