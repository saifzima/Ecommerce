using System;
using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IFoodManager
    {
        public void CreateFood (string foodName, double price);
        public void UpdateFood (string foodName,string newFoodName, double newFoodPrice );
        public void DeleteFood (string foodName);
        public Food GetFood (string foodName);
        public void GetAllFoods();

    }
}