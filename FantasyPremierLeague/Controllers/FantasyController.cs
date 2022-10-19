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

            foreach (var item in results_standings_list)
            {
                var entry_histories = await ApiOperations.GetEntryHistory(item.entry);//9 api calls
                for (int i = 1; i <= entry_histories.current.Count; i++)
                {
                    var entry_event_picks = await ApiOperations.GetEntryEventPicks(item.entry, i);//11 api calls
                    foreach (var auto_sub in entry_event_picks.automatic_subs)
                    {
                        if (auto_sub != null)
                        {
                            var element_summary = await ApiOperations.GetElementSummary(auto_sub.element_in);
                            var histories = element_summary.history;
                            foreach (var history in histories)
                            {
                                if (history.round == i)
                                {
                                    item.points_from_auto_subs += history.total_points;
                                }
                            }
                        }
                    }
                }

                foreach (var history in entry_histories.current)
                {
                    item.total_points_on_bench += history.points_on_bench;
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
