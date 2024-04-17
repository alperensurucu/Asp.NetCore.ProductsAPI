using Asp.NetCore.ProductsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.ProductsAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private static List<Product>? _products;

        //localhost:5000/api/prodcuts =>GET

        public ProductsController()  
        {
            _products = new List<Product>
            {
                new () { ProductId = 1, ProductName = "IPhone14", Price = 60000, IsActive = true },
                new () { ProductId = 2, ProductName = "IPhone15", Price = 70000, IsActive = true },
                new () { ProductId = 3, ProductName = "IPhone16", Price = 80000, IsActive = true },
                new () { ProductId = 4, ProductName = "IPhone17", Price = 90000, IsActive = true }
            };
        }    
        [HttpGet]
        public IActionResult GetProducts()
        {
            if (_products == null)
            {
                return NotFound(); 
            }
            return Ok(_products);
        }

        //localhost:5000/api/prodcuts/1 =>GET

        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var p  =_products?.FirstOrDefault(i => i.ProductId == id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }
    }
    


}
