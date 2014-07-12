using System;

namespace WithoutResponder
{
    public class PlaceAnOrderPresenter
    {
        public void HandleResponse(PlaceAnOrderResponse response)// Interpreting response not needed with responder interface.
        {
            if (response.OrderBlocked)
            {
                OrderBlocked();
                return;
            }

            OrderAdded(response.NewOrderId);
        }

        public void OrderAdded(int newOrderId)
        {
            Console.WriteLine("New order id: " + newOrderId);
        }

        public void OrderBlocked()
        {
            Console.WriteLine("Order blocked");
        }
    }// More lines without responder.
}
