using FantasyPremierLeague.Models;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class DreamteamController : Controller
    {
        #region API GetRequests
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

        public async Task<Rootobject> GetDreamteamByEventId(int? event_id)
        {
            Rootobject dreamteam;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/dream-team/{event_id}/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dreamteam = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return dreamteam;
        }

        public async Task<Rootobject> GetEventLiveDataByEventId(int? event_id)
        {
            Rootobject event_live_data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/event/{event_id}/live/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    event_live_data = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return event_live_data;
        }

        public async Task<List<Fixture>> GetFixtures()
        {
            List<Fixture> fixtures_list;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/fixtures/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    fixtures_list = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
                }
            }

            return fixtures_list;

        }

        #endregion

        #region Methods

        #endregion

        public async Task<IActionResult> Index()
        {
            var data = GetBootstrapStatic().Result;

            var elements_list = data.elements.ToList();

            var events_list = data.events.ToList();

            foreach (var item in events_list)
            {
                if (item.finished)
                {
                    var element = elements_list.First(x => x.id == item.top_element);

                    item.top_element_info.first_and_web_name = $"{element.first_name} {element.web_name}";

                }
            }

            DreamteamListViewModel viewModel = new DreamteamListViewModel()
            {
                events_list = events_list
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = GetBootstrapStatic().Result;

            var fixtures_list = GetFixtures().Result;

            var dreamteam_data = GetDreamteamByEventId(id).Result;

            var dreamteam = dreamteam_data.team.ToList();

            var elements_list = data.elements.ToList();
            var teams_list = data.teams.ToList();

            foreach (var item in dreamteam)
            {
                var element = elements_list.First(x => x.id == item.element);
                var element_team = teams_list.First(x => x.id == element.team);

                item.first_name_and_web_name = $"{element.first_name} {element.web_name}";
                item.team = element.team;
                item.team_name = element_team.name;
            }

            var event_live_data = GetEventLiveDataByEventId(id).Result;

            var dream_fixuters = fixtures_list.Where(x => (x.team_h_difficulty < 3 && x.team_a_difficulty > 3) || (x.team_a_difficulty < 3 && x.team_h_difficulty > 3)).ToList();
            var dreamteam_prediction = event_live_data.elements.OrderByDescending(x => double.Parse(x.stats.ict_index)).Take(11).ToList();

            foreach (var item in dreamteam_prediction)
            {
                var element = elements_list.First(x => x.id == item.id);
                item.first_name_and_web_name = $"{element.first_name} {element.web_name}";
            }

            DreamteamDetailViewModel viewModel = new DreamteamDetailViewModel()
            {
                dreamteam = dreamteam,
                dreamteam_prediction = dreamteam_prediction,
                fixtures_list = dream_fixuters,
            };

            return View(viewModel);
        }
    }
}
