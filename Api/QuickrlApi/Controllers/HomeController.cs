using Microsoft.AspNetCore.Mvc;

namespace QuickrlApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("QUickRL API");
        }
    }
}