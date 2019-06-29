using Microsoft.AspNetCore.Mvc;

namespace DigitalJump.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Internships()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }
    }
}