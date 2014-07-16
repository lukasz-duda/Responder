using System.Web.Mvc;

namespace WebWithoutResponder.Controllers
{
    public class PlaceAnOrderController : ControllerBase// Implementing responder here not needed without responder, response interpretation used instead.
    {
        public CamelCaseJsonResult PlaceAnOrder()
        {
            var useCase = new PlaceAnOrderUseCase();
            PlaceAnOrderResponse response = useCase.Execute();
            return UseCaseResponse(response);
        }
    }
}
