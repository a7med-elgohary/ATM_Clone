using ATM_clone.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.App_Program
{
    internal class Utilty
    {
        // get input from user
        public static string GetInput(string taskname) {

            Console.Write($"Enter the {taskname} >> ");

#pragma warning disable CS8603 // Possible null reference return.
            return Console.ReadLine();
#pragma warning restore CS8603 // Possible null reference return.
        }

        // check if proscess is sucsess or no 
        public static void proccesStatus(bool input) {
            if (input)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("process Sucsess");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("process fail");
                Console.ResetColor();
            }
        }

        // return owner of the account
        public static User getUser(string accountPIN, string accountPassword)
        {
            return DB.data.FirstOrDefault(entry => entry.Key.PIN == accountPIN && entry.Key.Password == accountPassword).Value;
        }
        public static Account getAccount(string accountPIN, string accountPassword)
        {

            return DB.data.FirstOrDefault(entry => entry.Key.PIN == accountPIN && entry.Key.Password == accountPassword).Key;
        }

        public static string makeNewId ()
        {
            string NewId =(int.Parse( DB.data.Last().Key.PIN)+1).ToString();
            
            return NewId;
        }
    }
}
