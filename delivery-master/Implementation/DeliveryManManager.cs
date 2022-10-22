using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class DeliveryManManager : IDeliveryManManager
    {    
        public static List<DeliveryMan> listOfDeliveryMen = new List<DeliveryMan>();

        public void CreateDeliveryMan(string firstName, string lastName, string email, int pin, string plateNumber, string phoneNumber)
        {
            Random rand = new Random();
            int id = listOfDeliveryMen.Count + 1;
            DeliveryMan dlm = new DeliveryMan(id, firstName, lastName, email, pin, plateNumber, phoneNumber);
            Console.WriteLine($"thank you mr {dlm.FirstName}, your staff identity number is {dlm.PlateNumber}");

        }

        public void DeleteDeliveryMan(string email)
        {
            DeliveryMan adm = GetDeliveryMan(email);
            if (adm != null)
            {
                listOfDeliveryMen.Remove(adm);
            }
            else
            {
                Console.WriteLine("deliveryman not found");
            }
        }

        public DeliveryMan GetDeliveryMan(string email)
        {
            foreach (var item in listOfDeliveryMen)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public DeliveryMan Login(string email, int pin)
        {
            foreach (var item in listOfDeliveryMen)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateDeliveryMan(string firstName, string lastName, string phoneNumber, string email)
        {
            DeliveryMan ad = GetDeliveryMan(email);
            if (ad == null)
            {
                Console.WriteLine("delivery man not found");
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