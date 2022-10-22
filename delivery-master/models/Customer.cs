namespace FDMS_App.models
{
    public class Customer : User
    {
        public string Address {get; set;}
        public string PhoneNumber {get; set;}
        public double Wallet {get; set;}

        public Customer(int id,string firstName, string lastName, string email, int pin,string address, string phoneNumber,double wallet ): base (id,firstName, lastName, email, pin)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            Wallet = wallet;
        }

    }
}