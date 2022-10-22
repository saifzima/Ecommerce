using FDMS_App.models;

namespace FDMS_App.Interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer (string firstName, string lastname, string email, int pin,string address, string phoneNumber);
        public void UpdateCustomer (string firstName, string lastName,string address, string phoneNumber, string email);
        public void DeleteCustomer (string email);
        public Customer GetCustomer (string email);
        public Customer Login(string email, int pin);
        public void AddMoneyToWallet(string email, double amount);
    }
}