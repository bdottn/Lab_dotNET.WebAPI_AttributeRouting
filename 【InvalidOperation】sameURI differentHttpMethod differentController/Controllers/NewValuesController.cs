using System.Web.Http;

namespace InvalidOperation_sameURI_differentHttpMethod_differentController.Controllers
{
    public sealed class NewValuesController : ApiController
    {
        [Route("values/{id:int}")]
        [HttpGet]
        public string GetValue(int id)
        {
            return "value is " + id;
        }

        [Route("values/{id:int}")]
        [HttpDelete]
        public string DeleteValue(int id)
        {
            return "delete value success !";
        }
    }
}