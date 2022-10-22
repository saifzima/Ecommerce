using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IChefManager
    {
       
        public void CreateChef (string firstName, string lastname, string email, int pin, string phoneNumber);
        public void UpdateChef (string firstName, string lastname, string phoneNumber, string staffId);
        public void DeleteChef (string staffId);
        public Chef GetChef (string staffId);
        public Chef GetChef(int id);
        public Chef Login (string email, int pin);
    }
}