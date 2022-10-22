namespace FDMS_App.models
{
    public class User
    {
        public int Id{ get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public int Pin {get; set;}

        public User(int id,string firstName, string lastname, string email, int pin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Pin = pin;
        }    

    }    
    
}