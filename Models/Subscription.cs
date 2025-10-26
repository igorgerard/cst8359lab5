namespace Lab5.Models
{
    public class Subscription
    {
        // composite key (configured in DbContext)
        public int CustomerId { get; set; }
        public string ServiceId { get; set; }

        // navigation properties
        public Customer Customer { get; set; }
        public FoodDeliveryService FoodDeliveryService { get; set; }
    }
}
