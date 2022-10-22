using System;
using FDMS_App.Implementation;
using FDMS_App.Interfaces;
using FDMS_App.models;
namespace FDMS_App.Menu
{
    public class DM
    {
        IDeliveryManManager deliveryManManager = new DeliveryManManager();

        public void DeliveryManMenu()
        {
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterDeliveryManMenu();
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

        public void RegisterDeliveryManMenu()
        {
            Console.WriteLine("Delivery Man Manager");

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

            Console.Write("Enter your bikeplateNumber: ");
            string bikeplateNumber = Console.ReadLine();

            deliveryManManager.CreateDeliveryMan(bikeplateNumber, fName, lName, email, phoneNumber, pin);
            DeliveryManMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            DeliveryMan customer = deliveryManManager.Login(email, pin);
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