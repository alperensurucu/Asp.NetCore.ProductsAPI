using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.ProductsAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        public static readonly string[] Products = {
        
            "IPhone 14","IPhone 15","IPhone 16"
        };
        //localhost:5000/api/prodcuts =>GET

        [HttpGet]
        public string[] GetProducts()
        {
            return Products; //Products listesini geri gönderir.
        }

        //localhost:5000/api/prodcuts/1 =>GET
        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return Products[id]; //Products listesini geri gönderir. İd filtrelemesiyle ama .
        }
    }
    


}
