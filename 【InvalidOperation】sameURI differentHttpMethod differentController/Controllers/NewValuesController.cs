using System.Web.Http;

namespace InvalidOperation_sameURI_differentHttpMethod_differentController.Controllers
{
    public sealed class NewValuesController : ApiController
    {
        [HttpGet, Route("values/{id:int}")]
        public string GetValue(int id)
        {
            return "value is " + id;
        }
    }
}