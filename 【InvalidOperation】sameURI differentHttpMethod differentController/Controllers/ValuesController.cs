using System.Web.Http;

namespace InvalidOperation_sameURI_differentHttpMethod_differentController.Controllers
{
    public sealed class ValuesController : ApiController
    {
        [HttpDelete, Route("values/{id:int}")]
        public string DeleteValue(int id)
        {
            return "delete value success !";
        }
    }
}