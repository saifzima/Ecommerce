using System;
using FDMS_App.Menu;

namespace FDMS_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            MM mm = new MM();
            mm.MainMenu();

            ChefM ch = new ChefM();
             ch.ChefMenu();

            CM customer = new CM();
            customer.CustomerMenu();

            DM deliveryman = new DM();
            deliveryman.DeliveryManMenu();
        }
    }
    
}
