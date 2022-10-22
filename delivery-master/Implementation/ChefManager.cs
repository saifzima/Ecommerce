using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class ChefManager : IChefManager
    {
        public static List<Chef> listOfChefs = new List<Chef>();

        public void CreateChef(string firstName, string lastname, string email, int pin, string phoneNumber)
        {
            Random rand = new Random();
            int id = listOfChefs.Count + 1;
            string staffId = "CLH/CH" + rand.Next(100, 999).ToString();
            Chef chf = new Chef(id, firstName, lastname, email, pin, staffId, phoneNumber);
            Console.WriteLine($"congratulations chef {chf.FirstName}, your staff identity number is {chf.StaffID}");

        }

        public void DeleteChef(string staffId)
        {
            Chef chf = GetChef(staffId);
            if (chf != null)
            {
                listOfChefs.Remove(chf);
            }
            else
            {
                Console.WriteLine("chef not found");
            }
        }

        public Chef GetChef(string staffId)
        {
            foreach (var item in listOfChefs)
            {
                if (item.StaffID == staffId)
                {
                    return item;
                }
            }
            return null;
        }

        public Chef GetChef(int id)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Chef Login(string email, int pin)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateChef(string firstName, string lastname, string phoneNumber, string staffId)
        {
            Chef ad = GetChef(staffId);
            if (ad == null)
            {
                Console.WriteLine("Chef not found");
            }
            else
            {
                ad.FirstName = firstName;
                ad.LastName = lastname;
                ad.PhoneNumber = phoneNumber;
            }
        }
    }
}