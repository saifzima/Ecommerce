using System;
using FDMS_App.Implementation;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Menu
{
    public class ChefM
    {
       IChefManager chefMananager = new ChefManager();

        public void ChefMenu()
        {
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterChefMenu();
            }
            else if(choice == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        public void RegisterChefMenu()
        {
            Console.WriteLine("Welcome to Chef Manager");

            Console.Write("Enter your firstname: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your lastname: ");
            string lName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter your chefID: ");
            string chefId = Console.ReadLine();

            Console.Write("Enter your chefphoneNumber: ");
            string chefphoneNumber = Console.ReadLine();

            chefMananager.CreateChef(fName, lName, email, pin, chefId);
            ChefMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Chef chef = chefMananager.Login(email, pin);
            if(chef != null)
            {
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }
        }
    }
}