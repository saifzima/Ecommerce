using System;

namespace FDMS_App.Menu
{
    public class MM
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Food Delivery Management System \nHow can we help you");

            Console.WriteLine("Enter 1 as Admin\nEnter 2 as Chef\nEnter 3 as Delivery\nEnter 4 as Customer");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                AM am = new AM();
                am.AdminMenu();
            }

            else if(opt == 2)
            {
                ChefM cm = new ChefM();
                cm.ChefMenu();
            }
            else if (opt == 3)
            {
                DM dm = new DM();
                dm.DeliveryManMenu();
            }
            else if (opt == 4)
            {
                CM cust = new CM();
                cust.CustomerMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}