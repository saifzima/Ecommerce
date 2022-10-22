namespace FDMS_App.models
{
    public class Chef : User
    {
        public string StaffID {get; set;}
        public string PhoneNumber {get; set;}
        
        public Chef(int id,string firstName, string lastName, string email, int pin, string staffId, string phoneNumber) : base (id,firstName, lastName, email, pin)
        {
            StaffID = staffId;
            PhoneNumber = phoneNumber;
        }

    }
}