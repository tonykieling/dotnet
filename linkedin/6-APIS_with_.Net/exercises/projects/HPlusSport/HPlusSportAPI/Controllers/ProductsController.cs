using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "OK";
        }
        [HttpPost]
        public int P()
        {
            return 8;
        }
        [HttpPatch]
        public string Update()
        {
            return "Product Updated!!";
        }
    }
}
