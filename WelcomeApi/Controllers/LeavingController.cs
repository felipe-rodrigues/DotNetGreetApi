using Microsoft.AspNetCore.Mvc;

namespace WelcomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavingController : ControllerBase
    {

        [HttpGet]
        public string SayGoogBye()
        {
            return "Goodbye";
        }
    }
}
