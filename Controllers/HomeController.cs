using Microsoft.AspNetCore.Mvc;

namespace test_demo_api.Controllers
{
    [ApiController]
    [Route("test/[controller]")]
    public class HomeController : ControllerBase
    {

        [Route("phone1")]
        [HttpGet]
        public string Index()
        {
            return "tsssss - Home - Index";
        }


        [Route("phone")]
        [HttpGet]
        public string Phone()
        {
            return "tsssss - Home - Phone";
        }


        [Route("[action]")]
        [HttpGet]
        public string Country()
        {
            return "tsssss - Home - Country";
        }

        [Route("")]
        [HttpGet]
        public string Test()
        {
            return "tsssss - Home - Test";
        }

    }
}
