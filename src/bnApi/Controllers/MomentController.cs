using Microsoft.AspNetCore.Mvc;

namespace bnApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class MomentController : ControllerBase
    {
        [HttpGet]
        public IActionResult AddMoment()
        {
            return Ok();
        }
    }
}
