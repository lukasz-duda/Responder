namespace WithoutResponder
{
    public class PlaceAnOrderUseCase
    {
        // It looks like command, is it Command-Query Separation violation?
        public PlaceAnOrderResponse Execute()
        {
            var response = new PlaceAnOrderResponse();// Dependency Inversion Principle violation?

            bool notValid = true;
            if (notValid)
            {
                response.OrderBlocked = true;
                return response;
            }

            response.NewOrderId = 5;
            return response;// Use case implementation has more lines without responder.
        }
    }
}
