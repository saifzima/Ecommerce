using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> listOfCustomers = new List<Customer>();

        public void AddMoneyToWallet(string email, double amount)
        {
            Customer adm = GetCustomer(email);
            if (adm != null)
            {
                adm.Wallet += amount;
                System.Console.WriteLine($"{amount} successfully added to wallet and balance is {adm.Wallet}");
                
            }
            else
            {
                Console.WriteLine("customer not found");
            }

        }

        public void CreateCustomer(string firstName, string lastname, string email, int pin, string address, string phoneNumber)
        {
            Random rand = new Random();
            int id = listOfCustomers.Count + 1;
            double wallet = 5000;
            string staffId = "CLH/CTM" + rand.Next(100, 999).ToString();
            Customer adm = new Customer(id, firstName, lastname, email, pin, staffId, phoneNumber, wallet);
            Console.WriteLine($"thank you mr {adm.FirstName}, your wallet balance is credited with {adm.Wallet}");

        }

        public void DeleteCustomer(string email)
        {
            Customer adm = GetCustomer(email);
            if (adm != null)
            {
                listOfCustomers.Remove(adm);
            }
            else
            {
                Console.WriteLine("customer not found");
            }
        }

        public Customer GetCustomer(string email)
        {
            foreach (var item in listOfCustomers)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Customer Login(string email, int pin)
        {
            foreach (var item in listOfCustomers)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateCustomer(string firstName, string lastName, string address, string phoneNumber, string email)
        {
            Customer ad = GetCustomer(email);
            if (ad == null)
            {
                Console.WriteLine("Customer not found");
            }
            else
            {
                ad.FirstName = firstName;
                ad.LastName = lastName;
                ad.PhoneNumber = phoneNumber;
            }
        }
    }
}