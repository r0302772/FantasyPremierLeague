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
    public class PlayerController : Controller
    {
        public async Task<IActionResult> Index(string team)
        {
            BootstrapStatic data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            var elements = data.elements.OrderBy(x => x.id).ToArray();
            var teamsList = data.teams.ToList();

            List<SelectListItem> teamsSelectList = teamsList.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(team))
            {
                elements = elements.Where(x => x.team.ToString() == team).OrderBy(x => x.element_type).ToArray();
            }

            PlayerListViewModel viewModel = new PlayerListViewModel()
            {
                elements = elements,
                teams = teamsSelectList
            };


            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            BootstrapStatic data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            ElementSummary summary;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/element-summary/{id}/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    summary = JsonConvert.DeserializeObject<ElementSummary>(apiResponse);
                }
            }

            var player = data.elements.FirstOrDefault(x => x.id == id);
            var position = data.element_types.FirstOrDefault(x => x.id == player.element_type);
            var playerstats = summary.history;

            PlayerDetailsViewModel viewModel = new PlayerDetailsViewModel()
            {
                Position = position,
                Player = player,
                PlayerStats = playerstats
            };

            return View(viewModel);
        }
    }
}
