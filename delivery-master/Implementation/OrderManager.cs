using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class OrderManager : IOrderManager
    {
        public static List<Order> listOfOrders = new List<Order>();
        ICustomerManager ctmg = new CustomerManager();
        IFoodManager fmg = new FoodManager();
        public void DeleteOrder(string refNumber)
        {
            Order adm = GetOrder(refNumber);
            if (adm != null)
            {
                listOfOrders.Remove(adm);
            }
            else
            {
                Console.WriteLine("order not found");
            }
        }

        public Order GetOrder(string refNumber)
        {
            foreach (var item in listOfOrders)
            {
                if (item.RefNumber == refNumber)
                {
                    return item;
                }
            }
            return null;
        }

        public void MakeOrder(string email, List<Food> foods)
        {
            Random rand = new Random();
            int id = listOfOrders.Count + 1;
            string refNumber = "CLH/ORDER" + rand.Next(100, 999).ToString();
            Customer cust = ctmg.GetCustomer(email);
            string customerName = cust.FirstName + " " + cust.LastName;
            string deliveryAddress = cust.Address;
            string status = "ordered";
            List<Food> listOfFoods = foods;
            double totalPrice = CalculatePrice(listOfFoods);

            if(cust.Wallet < totalPrice)
            {
                Console.WriteLine("insufficient balance");
                return;
            }
            else
            {
                Order ord = new Order(id, refNumber, customerName, deliveryAddress, status, totalPrice, listOfFoods);
                double balance = cust.Wallet - ord.TotalPrice;
                System.Console.WriteLine($"successful, your order reference is {ord.RefNumber}, price is {ord.TotalPrice} and new wallet balance {balance}");
            }

            
        }

        public double CalculatePrice(List<Food> asd)
        {
            double price = 0;
            foreach (var item in asd)
            {
                price += item.Price;
            }
            return price;
        }

        public void StatusToReady(string refNumber)
        {
            foreach (var item in listOfOrders)
            {
                if(item.OrderStatus == "ordered")
                {
                    item.OrderStatus = "Ready";
                }
            }
        }
    }
}