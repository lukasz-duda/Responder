using Responder;
using System.Web.Mvc;

namespace WebResponder.Controllers
{
    public class PlaceAnOrderController : ControllerBase, IPlaceAnOrderResponder
    {
        public JsonResult PlaceAnOrder()
        {
            var useCase = new PlaceAnOrderUseCase();
            useCase.Execute(this);
            return Json(Actions);
        }

        public void OrderAdded(int newOrderId)// Not needed without responder, response interpretation used instead.
        {
            Actions.Add(new { name = "orderAdded", arguments = new { newOrderId = 5 } });
        }

        public void OrderBlocked()// Not needed without responder, response interpretation used instead.
        {
            Actions.Add(new { name = "orderBlocked" });
        }
    }
}
