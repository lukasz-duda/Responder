using System.Web.Mvc;

namespace WebResponder.Controllers
{
    public class ShowNewOrderController : Controller
    {
        public ActionResult NewOrder()
        {
            return View();
        }
    }
}
