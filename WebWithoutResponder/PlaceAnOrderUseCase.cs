namespace WebWithoutResponder
{
    public class PlaceAnOrderUseCase
    {
        public PlaceAnOrderResponse Execute()
        {
            var response = new PlaceAnOrderResponse();

            bool notValid = true;
            if (notValid)
            {
                response.OrderBlocked = true;
                return response;
            }

            response.NewOrderId = 5;
            return response;
        }
    }
}
