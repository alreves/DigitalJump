using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DigitalJump.Models;
using DigitalJump.BL;
using System.Threading.Tasks;

namespace DigitalJump.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            StatProvider statProvider = new StatProvider ();
            var result = await statProvider.GetStatAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
