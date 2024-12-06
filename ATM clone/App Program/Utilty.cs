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
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
            return input;
#pragma warning restore CS8603 // Possible null reference return.
        }

        // check if proscess is sucsess or no 
        public static void  proccesStatus(bool input) {
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



    }
}
