using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            Console.WriteLine("Inside ProductsController Constructor");
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    //Console.WriteLine("within GETTTTTTTTTT");
        //    return _context.Products.ToArray();
        //}
        // the method above is the same as the below one, but the below is shorter

        // below is before adding async
        //public ActionResult GetAllProducts()
        //{
        //    Console.WriteLine("within GETTTTTTTTTT#");
        //    return Ok(_context.Products.ToArray());
        //}
        public async Task<ActionResult> GetAllProducts()
        {
            Console.WriteLine("within GETTTTTTTTTT#\n");
            return Ok(await _context.Products.ToArrayAsync());
        }

        //[Route("/api/products/{id}")]
        //[Route("{id}")]
        [HttpGet("{id}")]
        // the 3 ways above produce the same result, but the last one is a handy shortcut
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            Console.WriteLine($"product: { product}\n");
            if (product == null)
                return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public ActionResult Asd()
        {
            Console.WriteLine("POST!\n");
            return BadRequest("SOrry :/");
        }
    }
}
