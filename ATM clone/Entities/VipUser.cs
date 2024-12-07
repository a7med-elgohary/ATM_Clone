using ATM_clone.App_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone.Entities
{
    internal class VipUser: User
    {
        
        public VipUser(string firstname, string Lastname,string Password , string cardPIN)
        {
            Account = new Account(Password,cardPIN);
            FristName = firstname;
            LastName = Lastname;
            fulName = firstname + " " + Lastname;
            
        }

        internal static void AddnewUser()
        {
            var PIN=Utilty.makeNewId();
            string type =Utilty.GetInput("type of user normal or admin").ToLower();
            
            if (type == "admin"&& type.IsTypeMatch<string>())
            {
                var databaselenght = DB.data.Count();
                string fristname = Utilty.GetInput("frist name");
                string Lastname = Utilty.GetInput("second name");
                string password = Utilty.GetInput("Passowd");
                User newuser = new VipUser(fristname,Lastname,password,PIN);
                DB.data.Add(newuser.Account,newuser);
                show_infomation(newuser.Account.PIN);
                if (databaselenght ==databaselenght+1)
                
                    Utilty.proccesStatus(true);
                else
                    Utilty.proccesStatus(false);



            }
            else if (type == "normal" && type.IsTypeMatch<string>())
            {
                var databaselenght = DB.data.Count();

                string fristname = Utilty.GetInput("frist name");
                string Lastname = Utilty.GetInput("second name");
                string password = Utilty.GetInput("Passowd");
                User newuser = new normalUser(fristname, Lastname, password, PIN);
                DB.data.Add(newuser.Account, newuser);
                show_infomation(newuser.Account.PIN);
                    Utilty.proccesStatus(true);
               

            }



        }

        public static void show_infomation(string Id="")
        {
            if (Id == "")
            {  
                string id = Utilty.GetInput("id");
            }
            Account theaccount = DB.data.FirstOrDefault(c => c.Key.PIN==Id).Key;
            if (Validator.IsTypeMatch<int>(Id))
            {
                Console.WriteLine($"the account iformation : \nthe balance = {theaccount.Balance}\nthe PIN = {theaccount.PIN} the password = {theaccount.Password}");
                
            }
        }

        public void a7a()
        {

        }
    }
}
