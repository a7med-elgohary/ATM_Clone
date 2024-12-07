using ATM_clone.App_Program;
using ATM_clone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            User theuser = Utilty.getUser(cardPin, cardPassword);
            if (isValidate && theuser is normalUser)
                normalUserScreen(theuser);
            else if (isValidate && theuser is VipUser)
                VIPUserScreen(theuser);

            else
                Utilty.proccesStatus(isValidate);




        }

        private static void VIPUserScreen(User user)
        {
            
            Console.Clear();
            Account AccountOfuser = Utilty.getAccount(user.Account.PIN, user.Account.Password);
            
            
                Console.WriteLine($"+++++++++++++++++++++++++++++++ Welcome {user.fulName} +++++++++++++++++++++++++++++++\n\n");

                Console.WriteLine("              ++++++++++++++++++++ ATM ++++++++++++++++++++\n");
                Console.WriteLine("              **      1- Balance Inquiry                 **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      2- Cash Withdrawal                 **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      3- Cash Deposit                    **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      4- Add new User                    **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      5- Edit user                       **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      6- remove user                     **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      7- show infomation for any user    **\n");
                Console.WriteLine("              +++++++++++++++++++++++++++++++++++++++++++++\n\n");

                string Chooise = Utilty.GetInput("the choise");
                
                switch (Chooise)
                {
                    
                    case "1":
                        Console.Clear();
                        VipUser.Balance_Inquiry(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        VipUser.cashWithdrawal(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        VipUser.cash_Deposit(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        Console.Clear();
                        break ;
                    case "4":
                        Console.Clear();
                        VipUser.AddnewUser();
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        Console.Clear();
                        break;
                case "7":
                    foreach (var item in DB.data) 
                    {
                        Console.WriteLine($"thw account information \n");
                        VipUser.show_infomation();
                        Console.WriteLine($"\n==========================\n");

                    }

                    break;
                    default:
                        Console.WriteLine("the action not rigte");
                        break;
                }
            
        }
        private static void normalUserScreen(User user)
        {
            Console.Clear();
            Account AccountOfuser = Utilty.getAccount(user.Account.PIN, user.Account.Password);
            while (true)
            {
                Console.WriteLine($"++++++++++++++++++++ Welcome {user.fulName} ++++++++++++++++++++\n");

                Console.WriteLine("              ++++++++++++++++++++ ATM ++++++++++++++++++++\n");
                Console.WriteLine("              **      1- Balance Inquiry                 **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      2- Cash Withdrawal                 **\n");
                Console.WriteLine("              **    --------------------------------     **\n");
                Console.WriteLine("              **      3- Cash Deposit                    **\n");
                Console.WriteLine("              +++++++++++++++++++++++++++++++++++++++++++++\n");

                Console.WriteLine($"\n\n");
                string Chooise = Utilty.GetInput("the choise");

                switch (Chooise)
                {
                    case "1":
                        Console.Clear();
                        normalUser.Balance_Inquiry(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        normalUser.cashWithdrawal(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        break;
                    case "3":
                        Console.Clear();
                        normalUser.cash_Deposit(AccountOfuser);
                        Console.WriteLine($"press enter to countnue {Console.ReadLine()}");
                        break;
                    default:
                        Console.WriteLine("the action not rigte");
                        break;
                }
            }
        }

    }
















    }

