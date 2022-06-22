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
    public class TeamController : Controller
    {
        public async Task<IActionResult> Index()
        {
            BootstrapStatic teamList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                teamList = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
            }
            return View(teamList);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BootstrapStatic teamList;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    teamList = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            var team = teamList.teams.FirstOrDefault(x => x.id == id);
            if (team == null)
            {
                return NotFound();
            }

            TeamDetailsViewModel viewModel = new TeamDetailsViewModel()
            {
                name = team.name,
                short_name = team.short_name,
                position = team.position,
                win = team.win,
                draw = team.draw,
                loss = team.loss,
                strength = team.strength,
                strength_overall_home = team.strength_overall_home,
                strength_overall_away = team.strength_overall_away,
                strength_attack_home = team.strength_attack_home,
                strength_attack_away = team.strength_attack_away,
                strength_defence_home = team.strength_defence_home,
                strength_defence_away = team.strength_defence_away,
                unavailable = team.unavailable
            };

            return View(viewModel);
        }
    }
}
