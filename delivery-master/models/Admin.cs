namespace FDMS_App.models
{
    public class Admin : User
    {
        public string StaffID {get; set;}
        public string PhoneNumber {get; set;}
        public string Position{ get; set; }

        public Admin(int id, string , string lastName,string email, int pin,string staffId, string phoneNumber, string position) : base (id,firstName, lastName, email, pin)
        {
            StaffID = staffId;
            PhoneNumber = phoneNumber;
            Position = position;
        }
    }
}