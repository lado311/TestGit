using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestprojectForGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Test()
        {
            return Ok("Hello, World!");
        }
    }
}
