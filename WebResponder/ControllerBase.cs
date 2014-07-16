using System.Collections.Generic;
using System.Web.Mvc;

namespace WebResponder
{
    public class ControllerBase : Controller
    {
        private IList<object> actions = new List<object>();

        public IList<object> Actions
        {
            get { return actions; }
        }
    }
}