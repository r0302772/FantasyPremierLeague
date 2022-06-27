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
        #region API GetRequests
        [NonAction]
        public async Task<Rootobject> GetData()
        {
            Rootobject data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return data;
        }

        [NonAction]
        public async Task<List<Fixture>> GetFixtures()
        {
            List<Fixture> fixtureList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            return fixtureList;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            var fixtures_list = GetFixtures().Result;

            FixtureListViewModel viewModel = new FixtureListViewModel()
            {
                fixtures_list = fixtures_list
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var fixtures_list = GetFixtures().Result;

            FixtureDetailsViewModel viewModel = new FixtureDetailsViewModel()
            {
                //fixtures = fixtures_list
            };

            return View(viewModel);
        }
    }
}
