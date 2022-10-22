using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmins = new List<Admin>();

        public void CreateAdmin(string firstName, string lastName, string email, int pin, string phoneNumber, string position)
        {
            Random rand = new Random();
            int id = listOfAdmins.Count + 1;
            string staffId = "CLH/AD" + rand.Next(100, 999).ToString();
            Admin adm = new Admin(id, firstName, lastName, email, pin, staffId, phoneNumber, position);
            Console.WriteLine($"thank you mr {adm.FirstName}, your staff identity number is {adm.StaffID}");

        }

        public void DeleteAdmin(string staffId)
        {
            Admin adm = GetAdmin(staffId);
            if(adm != null)
            {
                listOfAdmins.Remove(adm);
            }
            else
            {
                Console.WriteLine("admin not found");
            }
        }

        public Admin GetAdmin(string staffId)
        {
            foreach (var item in listOfAdmins)
            {
                if(item.StaffID == staffId)
                {
                    return item;
                }
            }
            return null;
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in listOfAdmins)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(string firstName, string lastname, string phoneNumber, string staffId)
        {
            Admin ad = GetAdmin(staffId);
            if(ad == null)
            {
                Console.WriteLine("Admin not found");
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