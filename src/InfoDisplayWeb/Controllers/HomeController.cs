﻿using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InfoDisplayWeb.Controllers
{
    [Route("[controller]"), Route("/")]
    public class HomeController : Controller
    {
        [Route("[action]"), Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
