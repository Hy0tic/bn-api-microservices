using Microsoft.AspNetCore.Mvc;

namespace bnApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, world!");
        }
    }
}
