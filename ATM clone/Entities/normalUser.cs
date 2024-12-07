using ATM_clone.App_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.Entities
{
    internal class normalUser:User
    {
        public normalUser()
        {
            
        }
        public normalUser(string firstname, string Lastname, string Password, string cardPIN)
        {
            Account = new Account(Password, cardPIN);
            FristName = firstname;
            LastName = Lastname;
            fulName = firstname + " " + Lastname;

        }
        
    }
}
