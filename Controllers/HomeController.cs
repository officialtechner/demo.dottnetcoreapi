using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using test_demo_api.Models;

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

        [Route("[action]")]
        [HttpGet]
        public ContentResult GetUserText()
        {
            return Content("Testing the content.");
        }

        [Route("[action]")]
        [HttpGet]
        public ObjectResult GetUserObject()
        {
            var user = new User { ID = 1, Name = "Test" };
            return new ObjectResult(user);
        }

        [Route("[action]")]
        [HttpGet]
        public ViewResult GetUserView()
        {
            return new ViewResult();
        }

        [Route("[action]")]
        [HttpGet]
        public ViewResult GetUserPassingData()
        {
            //@todo
            var user = new User { ID = 1, Name = "Test" };

            return new ViewResult();
        }

    }
    }
