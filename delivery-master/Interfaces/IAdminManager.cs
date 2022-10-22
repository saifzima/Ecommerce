using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IAdminManager
    {  
       public void CreateAdmin (string firstName, string lastName, string email, int pin, string phoneNumber, string position);
       public void UpdateAdmin (string firstName, string lastname, string phoneNumber, string staffId);
       public void DeleteAdmin (string staffId);
       public Admin GetAdmin (string staffId);
       public Admin Login (string email, int pin);
    }
}   