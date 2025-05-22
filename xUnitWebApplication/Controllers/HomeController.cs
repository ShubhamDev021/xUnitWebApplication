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

        public string GuessNumber(int number)
        {
            if (number > 100)
            {
                return "Wrong!!! You guessed a large number";
            }
            else if (number < 100)
            {
                return "Wrong!!! You guessed a small number";
            }
            else
            {
                return "Hurray!!! You guessed the right number";
            }
        }
    }
}
