using System.Web.Mvc;
using System.Web.Routing;

namespace WebResponder
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "ShowNewOrder", action = "NewOrder" }
            );
        }
    }
}