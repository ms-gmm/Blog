using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult CheckHealth()
        {
            return Ok();
        }
    }
}
