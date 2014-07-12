namespace WithoutResponder
{
    public class PlaceAnOrderResponse
    {
        public int NewOrderId { get; set; }

        // If order is blocked why someone has to see new order id? Interface Segregation Principle violation?
        public bool OrderBlocked { get; set; }
    }
}
