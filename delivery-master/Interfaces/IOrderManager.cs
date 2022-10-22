using FDMS_App.models;
using System.Collections.Generic;

namespace FDMS_App.Interfaces
{
    public interface IOrderManager
    {
        public void MakeOrder(string email, List<Food> foods);
        public void DeleteOrder(string refNumber);
        public Order GetOrder(string refNumber);
        public void StatusToReady(string refNumber);

    }

}