using FDMS_App.models;

namespace FDMS_App.Interfaces
{
    public interface IDeliveryManManager
    {     
        public void CreateDeliveryMan(string firstName, string lastName, string email, int pin,string plateNumber, string phoneNumber);
         public void UpdateDeliveryMan( string firstName, string lastName, string phoneNumber, string email);
         public void DeleteDeliveryMan(string email);
         public DeliveryMan GetDeliveryMan(string email);
         public DeliveryMan Login(string email, int pin);
    }
}