using System.Web.Mvc;

namespace WebWithoutResponder
{
    public class ControllerBase : Controller
    {
        protected CamelCaseJsonResult UseCaseResponse(object response)
        {
            return new CamelCaseJsonResult(response);
        }
    }
}