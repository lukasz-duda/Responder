using System;

namespace Responder
{
    public class PlaceAnOrderPresenter : IPlaceAnOrderResponder
    {
        public void OrderAdded(int newOrderId)
        {
            Console.WriteLine("New order id: " + newOrderId);
        }

        public void OrderBlocked()
        {
            Console.WriteLine("Order blocked");
        }
    }
}
