using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;
namespace FDMS_App.Implementation
{
    public class FoodManager : IFoodManager
    {
        public static List<Food> listOfFoods = new List<Food>();

        public void CreateFood(string foodName, double price)
        {
            Random rand = new Random();
            int id = listOfFoods.Count + 1;
            Food fd = new Food(id, foodName, price);
            Console.WriteLine($"thank you, {fd.FoodName} created succesfully");

        }

        public void DeleteFood(string foodName)
        {
            Food adm = GetFood(foodName);
            if (adm != null)
            {
                listOfFoods.Remove(adm);
            }
            else
            {
                Console.WriteLine("food not found");
            }
        }

        public void GetAllFoods()
        {
            foreach (var item in listOfFoods)
            {
                Console.Write($"{item.Id}\t{item.FoodName}\t{item.Price}");
            }
            Console.WriteLine();
        }

        public Food GetFood(string foodName)
        {
            foreach (var item in listOfFoods)
            {
                if (item.FoodName == foodName)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateFood(string foodName, string newFoodName, double newFoodPrice)
        {
            Food ad = GetFood(foodName);
            if (ad == null)
            {
                Console.WriteLine("food not found");
            }
            else
            {
                ad.FoodName = newFoodName;
                ad.Price = newFoodPrice;
            }
        }
    }
}