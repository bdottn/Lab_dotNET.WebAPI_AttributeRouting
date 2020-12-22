using System.Web.Http;

namespace InvalidOperation_sameURI_differentHttpMethod_differentController
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}