using ATM_clone.App_Program;
using ATM_clone.Entities;
using ATM_clone.UI;

internal class Program
{
    public static void addusers()
    {
        Account ahmedaccount = new Account("111","123",123456789);
        User newuser = new User("ahmed","elgohary",ahmedaccount);
        
        DB.data.Add(ahmedaccount,newuser);

        
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