using System.Web.Mvc;

namespace WebWithoutResponder.Controllers
{
    public class ShowNewOrderController : Controller
    {
        public ActionResult NewOrder()
        {
            return View();
        }
    }
}
