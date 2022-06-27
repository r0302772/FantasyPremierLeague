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
    public class FantasyController : Controller
    {
        #region API GetRequests
        [NonAction]
        public async Task<Rootobject> GetLeagueStandingsByLeagueId(int? league_id)
        {
            Rootobject league;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/leagues-classic/{league_id}/standings"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    league = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return league;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> LeagueStandings(int? id)
        {
            var zaadschieters_league_id = 12695;
            var data = GetLeagueStandingsByLeagueId(zaadschieters_league_id).Result;

            var league = data.league;
            var standings = data.standings;
            var results_standings_list = standings.results.ToList();

            foreach (var item in results_standings_list)
            {
                item.point_difference_first_place = results_standings_list.First().total - item.total;
                item.point_difference_last_place = item.total - results_standings_list.Last().total;
                if (item != results_standings_list.First())
                {
                    item.point_difference_place_up = results_standings_list[results_standings_list.IndexOf(item) - 1].total - item.total;
                };
                if (item != results_standings_list.Last())
                {
                    item.point_difference_place_down = item.total - results_standings_list[results_standings_list.IndexOf(item) + 1].total;
                }
            }

            LeagueDetailsViewModel viewModel = new LeagueDetailsViewModel()
            {
                league = league,
                results_standings_list = results_standings_list
            };

            return View(viewModel);
        }
    }
}
