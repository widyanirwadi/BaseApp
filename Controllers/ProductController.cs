using BaseApp.Context;
using BaseApp.Contracts;
using BaseApp.Models;
using BaseApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        [HttpGet("GetProductByKey")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public async Task<IActionResult> GetProductByKey(int ProductID)
        {
            IEnumerable<Product> products = await _ProductRepository.GetProductByKey(ProductID);
            return Ok(products);

        }
    }
}
