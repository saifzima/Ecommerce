using System;
using FDMS_App.Implementation;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Menu
{
    public class CM
    {
        ICustomerManager customerManager = new CustomerManager();

         public void CustomerMenu()
        {
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterCustomerMenu();
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

        public void RegisterCustomerMenu()
        {
            Console.WriteLine("Welcome");

            Console.Write("Enter your firstname: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your lastname: ");
            string lName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter your phoneNumber: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            customerManager.CreateCustomer(address, phoneNumber, fName, lName, email, pin);
            CustomerMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Customer customer = customerManager.Login(email, pin);
            if(customer != null)
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