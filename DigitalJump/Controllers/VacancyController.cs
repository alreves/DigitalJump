using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalJump.BL.Service;
using DigitalJump.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalJump.Controllers
{
    public class VacancyController : Controller
    {
        public async Task<IActionResult> Index(string uid)
        {
            VacancyViewModel model = new VacancyViewModel();

            VacancyProvider vacancyProvider = new VacancyProvider();
            var curVac = await vacancyProvider.GetVacancyByUidAsync(new Guid(uid));
            model.CurrentVacancy = curVac;

            return View(model);
        }
    }
}