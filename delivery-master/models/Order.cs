using System.Collections.Generic;

namespace FDMS_App.models
{
    public class Order
    {
        public int Id{ get; set; } //object
        public string RefNumber{ get; set; }
        public string CustomerName {get; set;}
        public string DeliveryAddress {get; set;}
        public string OrderStatus {get; set;}
        public double TotalPrice {get; set;}
        public List<Food> OrderedFoods { get; set; }

        public Order (int id, string refNumber, string customerName, string deliveryAddress, string orderStatus, double totalPrice, List<Food> foods)
        {
            Id = id;
            RefNumber = refNumber;
            CustomerName = customerName; //constrator
            DeliveryAddress = deliveryAddress;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            OrderedFoods = foods;
        }

    }
}