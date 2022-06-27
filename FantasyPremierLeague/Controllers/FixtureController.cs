using FantasyPremierLeague.Models;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<Rootobject> GetBootstrapStatic()
        {
            Rootobject bootstrap_static;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bootstrap_static = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return bootstrap_static;
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

        public async Task<IActionResult> Index(string team_id, string event_id, string phase_id)
        {   
            var data = GetBootstrapStatic().Result;

            var fixtures_list = GetFixtures().Result;

            var teams_list = data.teams.ToList();

            var events_list = data.events.ToList();

            var phases_list = data.phases.ToList();

            #region SelectLists
            List<SelectListItem> teams_selectlist = teams_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(team_id))
            {
                fixtures_list = fixtures_list
                                   .Where(x => x.team_h.ToString() == team_id || x.team_a.ToString() == team_id)
                                   .ToList();
            }

            List<SelectListItem> events_selectlist = events_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(event_id))
            {
                fixtures_list = fixtures_list
                                   .Where(x => x.Event.ToString() == event_id)
                                   .ToList();
            }

            List<SelectListItem> phases_selectlist = phases_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            //if (!string.IsNullOrEmpty(phase_id))
            //{
            //    fixtures_list = fixtures_list
            //                       .Where(x => x.Event.ToString() == phase_id)
            //                       .ToList();
            //}
            #endregion

            foreach (var item in fixtures_list)
            {
                item.team_h_name = teams_list.First(x => x.id == item.team_h).name;
                item.team_a_name = teams_list.First(x => x.id == item.team_a).name;
            }

            FixtureListViewModel viewModel = new FixtureListViewModel()
            {
                fixtures_list = fixtures_list,
                teams_selectlist = teams_selectlist,
                events_selectlist = events_selectlist,
                phases_selectlist = phases_selectlist,
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
