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
        public Account Account { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string fulName {  get; set; }
        
        public User(string firstname ,string Lastname,Account account ) 
        {
            Account = account; 
            FristName = firstname;
            LastName = Lastname;
            fulName = firstname +" "+ Lastname;
            Entities.Account userAccount = new Account(account.Password,account.PIN);
            Account = userAccount; 
            
        }
        
    }
}
