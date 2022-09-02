using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("")]
    [ApiController]

    // Index class when user reaches the root place
    public class Index : ControllerBase
    {
        public ActionResult Abc()
        {
            Console.WriteLine("INDEX!!!!!!!!!!!!");
            return Ok("index");
        }
    }
}
