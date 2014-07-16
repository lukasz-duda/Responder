using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web;
using System.Web.Mvc;

namespace WebWithoutResponder
{
    public class CamelCaseJsonResult : System.Web.Mvc.JsonResult
    {
        public CamelCaseJsonResult(object data)
        {
            Data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";

            string serializedData = SerializeData();
            response.Write(serializedData);
        }

        private string SerializeData()
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(Data, settings);
        }
    }
}