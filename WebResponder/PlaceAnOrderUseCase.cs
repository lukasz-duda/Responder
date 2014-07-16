namespace Responder
{
    public class PlaceAnOrderUseCase
    {
        public void Execute(IPlaceAnOrderResponder responder)
        {
            bool notValid = true;
            if (notValid)
            {
                responder.OrderBlocked();
                return;
            }

            responder.OrderAdded(5);
        }
    }
}
