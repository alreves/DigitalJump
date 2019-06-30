using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DigitalJump.Models;
using DigitalJump.BL.Service;
using System.Threading.Tasks;
using DigitalJump.BL.Entities;

namespace DigitalJump.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel();

            StatProvider statProvider = new StatProvider();
            model.MainStat = await statProvider.GetStatAsync();

            VacancyProvider vacancyProvider = new VacancyProvider();
            var hotVacancies = await vacancyProvider.GetVacancyAsync();
            model.HotVacancies = hotVacancies.Take(10).ToList();

            return View(model);
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
