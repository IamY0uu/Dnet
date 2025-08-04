using Microsoft.AspNetCore.Mvc;

namespace SampleDotNetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from .NET Core Web API!";
        }
    }
}
