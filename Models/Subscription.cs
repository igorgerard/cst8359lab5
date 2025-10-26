namespace Lab5.Models
{
    public class Subscription
    {
        public int CustomerId { get; set; }
        public string ServiceId { get; set; }

       
        public Customer Customer { get; set; }
        public FoodDeliveryService FoodDeliveryService { get; set; }
    }
}
