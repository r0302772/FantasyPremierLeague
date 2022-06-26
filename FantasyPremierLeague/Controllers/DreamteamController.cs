using FantasyPremierLeague.Models;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class DreamteamController : Controller
    {
        public async Task<IActionResult> Index()
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

            var events = data.events.ToList();

            DreamteamListViewModel viewModel = new DreamteamListViewModel()
            {
                events = events
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {

            Rootobject dreamteamData;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/dream-team/{id}/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dreamteamData = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            Rootobject data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            var team = dreamteamData.team.ToList();
            List<Element> players = new List<Element>();
            foreach (var player in team)
            {
                var found = data.elements.First(x => x.id == player.element);
                players.Add(found);
            }

            var prediction = data.elements.Where(x =>
                                                 x.element_type == 1 &&
                                                 x.team == 1).ToList();


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
                Players = players,
                prediction = prediction
            };

            return View(viewModel);
        }
    }
}
