using ATM_clone.App_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.Entities
{
    internal  class Account
    {
        public string Password { get; set; }
        public string PIN { get; set; }
        public uint Balance { get; set; }


        public  Account(string password, string pin)
        {
            Password = password;
            PIN = pin;
        }

        public Account( string password,string pin ,  uint blance)
        {
            Password = password;
            PIN = pin;
            Balance = blance;
        }

       
    }
}
