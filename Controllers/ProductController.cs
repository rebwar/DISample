using DiSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;

        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(repository.GetProducts());
        }
    }
}