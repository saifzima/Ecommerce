using System;
using FDMS_App.Implementation;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Menu
{
    public class AM
    {
        IAdminManager adminManager = new AdminManager();

        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterAdminMenu();
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

        public void RegisterAdminMenu()
        {
            Console.WriteLine("Welcome to Admin Manager");

            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter your phoneNumber: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your adminId: ");
            int adminID = int.Parse(Console.ReadLine()) ;

            adminManager.CreateAdmin(fName, lName, email, pin, phoneNumber,position);
            AdminMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Admin admin = adminManager.Login(email, pin);
            if(admin != null)
            {
                Console.WriteLine("login successful");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }

        }

        public void AdminSubMenu()
        {
            Console.WriteLine("Enter 1 to register food\nEnter 2 to update food");
        }

    }
}