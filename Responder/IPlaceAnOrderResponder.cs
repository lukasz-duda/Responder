namespace Responder
{
    public interface IPlaceAnOrderResponder
    {
        void OrderAdded(int newOrderId);

        void OrderBlocked();
    }
}
