using Microsoft.AspNetCore.Mvc;
using MiniE_TicaretApplication.Abstraction;

namespace ETicaret.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService= productService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products=_productService.GetProducts();
            return Ok(products);
        }
    }
}
