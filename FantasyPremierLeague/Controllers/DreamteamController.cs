using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class DreamteamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
