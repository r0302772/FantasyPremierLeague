using FantasyPremierLeague.DataAcces;
using FantasyPremierLeague.DataAcces.UnitOfWork;
using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.bootstrap_static;
using FantasyPremierLeague.Models.event_status;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUnitOfWork _uow;
        public HomeController(/*IUnitOfWork uow*/)
        {
            //_uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            //var bootstrap_static = await ApiOperations.GetBootstrapStatic("bootstrap-static/");
            var event_status = await ApiOperations.GetEventStatus();
            
            //unitOfWork
            //var bootstrap = await _uow.BootstrapStaticRepository.Get("bootstrap-static/");
            //var event_status = await _uow.BootstrapStaticRepository.Get("event-status/");

            HomeViewModel viewModel = new HomeViewModel()
            {
                eventStatusRootobject = event_status
            };

            //return View(JsonConvert.DeserializeObject<EventStatusRootobject>(await client.GetStringAsync(baseAdress + eventStatusRootobject.endpoint)));
            return View(viewModel);
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
