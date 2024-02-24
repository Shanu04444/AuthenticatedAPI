// ProductController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticatedAPI.Controllers
{
    [Authorize] // Requires authorization for all actions in this controller
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // Your controller actions here
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic to get all products
            return Ok("Get all products");
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            // Your logic to get products by category
            return Ok($"Get all products in category with id {categoryId}");
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            // Your logic to add the product to the database
            return Ok($"Added product {product.Name} to the database");
        }
    }
}
