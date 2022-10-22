namespace FDMS_App.models
{
    public class Food
    {
        public int Id{ get; set; }
        public string FoodName {get; set;}
        public double Price {get; set;}

        public Food (int id, string foodName, double price)
        {
            Id = id;
            FoodName = foodName;
            Price = price;
        }
    }
}