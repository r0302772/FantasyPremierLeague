using FantasyPremierLeague.DataAcces;
using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.leagues_classic_standings;
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
        public FantasyController()
        {

        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> LeagueStandings(int? id)
        {
            var data = await ApiOperations.GetLeaguesClassicStandings(id);

            var league = data.league;
            var results_standings_list = data.standings.results.ToList();
            var results_new_entries_list = data.new_entries.results.ToList();

            results_standings_list.AddRange(results_new_entries_list);

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
