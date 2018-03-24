using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvcMiddleware.Auth;
using NetCoreMvcMiddleware.Constraints;

namespace NetCoreMvcMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [IsMobile]
        [ActionName("Index")]
        public IActionResult IndexMobile()
        {
            return Content("The Mobile Index View");
        }

        [LocalAuthorize]
        public IActionResult Edit()
        {
            return Content("The Edit Action Method");
        }

        public IActionResult GetCustomer()
        {
            return Ok( new { Id = 3, FistName = "Edgar", LastName = "Gonzalez"});
        }

        [HttpPost]
        public IActionResult Edit(int id, string name)
        {
            return Content("The Edit Action Method with parameters");
        }

        //[LogAction]
        [ResultLog]
        public IActionResult Splash()
        {
            return Content("This is a Splash Page");
        }
    }
}
