using FantasyPremierLeague.Models;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class FixtureController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Fixture[] fixtureList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<Fixture[]>(apiResponse);
            }

            BootstrapStatic data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            FixtureListViewModel viewModel = new FixtureListViewModel()
            {
                events = fixtureList
            };

            return View(viewModel);
        }
    }
}
