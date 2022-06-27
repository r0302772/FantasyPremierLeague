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

        public async Task<Rootobject> GetDreamteamByEventId(int? id)
        {
            Rootobject dreamteam;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/dream-team/{id}/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dreamteam = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return dreamteam;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            var data = GetBootstrapStatic().Result;

            var elements_list = data.elements.ToList();

            var events_list = data.events.ToList();

            foreach (var item in events_list)
            {
                var element = elements_list.First(x => x.id == item.top_element);

                item.top_element_info.first_and_web_name = $"{element.first_name} {element.web_name}";
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

            var dreamteam = GetDreamteamByEventId(id).Result;

            var team = dreamteam.team.ToList();

            List<string> element_first_and_web_names = new List<string>();

            foreach (var item in team)
            {
                var element = data.elements.First(x => x.id == item.element);

                element_first_and_web_names.Add($"{element.first_name} {element.web_name}");
            }

            //var prediction = data.elements.Where(x =>
            //                                     x.element_type == 1 &&
            //                                     x.team == 1).ToList();


            //List<History> predictionSummary = new List<History>();
            //foreach (var item in prediction)
            //{
            //    Rootobject summaryData;
            //    using (var httpClient = new HttpClient())
            //    {
            //        using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/element-summary/{item.id}/"))
            //        {
            //            string apiResponse = await response.Content.ReadAsStringAsync();
            //            summaryData = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
            //        }
            //    }
            //    var round = summaryData.history.FirstOrDefault(x => x.round == id);
            //    predictionSummary.Add(round);
            //}



            DreamteamDetailViewModel viewModel = new DreamteamDetailViewModel()
            {
                team = team,
                element_first_and_web_names = element_first_and_web_names,
            };

            return View(viewModel);
        }
    }
}
