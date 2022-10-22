namespace FDMS_App.models
{
    public class DeliveryMan : User
    {
        public string PlateNumber {get; set;}
        public string PhoneNumber {get; set;}

        public DeliveryMan(int id, string firstName, string lastName, string email, int pin, string plateNumber, string phoneNumber) : base (id, firstName, lastName, email, pin)
        {
            PlateNumber = plateNumber;
            PhoneNumber = phoneNumber;
        }
    }
}