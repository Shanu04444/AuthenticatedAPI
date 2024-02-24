// ShoppingCartController.cs

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticatedAPI.Controllers
{
    [Authorize] // Requires authorization for all actions in this controller
    [ApiController]
    [Route("api/[controller]")]
    public class ShopCartController : ControllerBase
    {
        // Your controller actions here
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic to get the user's shopping cart items
            return Ok("Get all products in the user's shopping cart");
        }

        [HttpPost("remove/{id}")]
        public IActionResult RemoveItem(int id)
        {
            // Your logic to remove the item from the shopping cart
            return Ok($"Removed item with id {id} from the shopping cart");
        }

        [HttpPost("add/{id}")]
        public IActionResult AddItem(int id)
        {
            // Your logic to add the item to the shopping cart
            return Ok($"Added item with id {id} to the shopping cart");
        }
    }
}
