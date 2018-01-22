using Microsoft.AspNetCore.Mvc;

namespace WPL.Orders.Controllers
{
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}