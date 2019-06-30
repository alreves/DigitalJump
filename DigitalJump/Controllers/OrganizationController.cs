using DigitalJump.BL.Service;
using DigitalJump.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DigitalJump.Controllers
{
    public class OrganizationController : Controller
    {
        public async Task<IActionResult> Index(string specUid = "")
        {
            CandidatsViewModel model = new CandidatsViewModel();

            CandidateProvider candidateProvider = new CandidateProvider();
            var candidats = await candidateProvider.GetCandidats(specUid);
            model.Candidats = candidats;

            StatProvider statProvider = new StatProvider();
            model.MainStat = await statProvider.GetStatAsync();

            return View(model);
        }

        public IActionResult Jobs()
        {
            return View();
        }
    }
}