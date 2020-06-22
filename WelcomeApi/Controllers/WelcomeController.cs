using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {

        [HttpGet]
        public string SayHello()
        {
            return "Hello World";
        }

        [HttpGet("hi")]
        public string SayHi()
        {
            return "Hi";
        }
    }
}
