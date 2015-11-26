using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InfoDisplayWeb.Controllers
{
    [Authorize]
    [Route("[controller]"), Route("/")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Route("[action]"), Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
