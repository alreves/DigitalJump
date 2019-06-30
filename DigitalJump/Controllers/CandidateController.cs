using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalJump.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index(Guid uid)
        {
            return View();
        }

        public IActionResult Analytics(Guid uid)
        {
            return View();
        }
    }
}