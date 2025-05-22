using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xUnitWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "I am in Home Controller";
        }
    }
}
