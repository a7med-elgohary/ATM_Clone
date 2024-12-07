using ATM_clone.App_Program;
using ATM_clone.Entities;
using ATM_clone.UI;

internal class Program
{
    public static void addusers()
    {
        User Adminuser = new VipUser("ahmed","elgohary","111", "123");
        DB.data.Add(Adminuser.Account,Adminuser);
        User normalUser = new normalUser("abod","elgohary","222","1234");
        DB.data.Add(normalUser.Account, normalUser);


    }


    private static void Main(string[] args)
    {
        while (true)
        {
            addusers();
            App.WelcomeScreen();
        }
    }
}