using System.Web;
using System.Web.Http;

namespace InvalidOperation_sameURI_differentHttpMethod_differentController
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}