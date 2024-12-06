using ATM_clone.App_Program;
using ATM_clone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.UI
{
    internal class App
    {
        public static void WelcomeScreen() 
        {
            Console.WriteLine("++++++++++++++++++++ ATM ++++++++++++++++++++\n");
            string cardPin = Utilty.GetInput("your cards PIN");
            string cardPassword = Utilty.GetInput("your password");
            var isValidate= Validator.AccountValidator(cardPin,cardPassword, DB.data );
            if (isValidate)
                UserScreen(Validator.getUser(cardPin, cardPassword));  
            else
                Utilty.proccesStatus(isValidate);




        }

        private static void UserScreen(User userAcouunt)
        {
            Console.Clear();
            Console.WriteLine($"++++++++++++++++++++ Welcome {userAcouunt.fulName} ++++++++++++++++++++");
            Console.WriteLine($"1- Show the Balance Inquiry\n2- Cash Withdrawal\n3-Cash Deposit");
        }
    }
}
