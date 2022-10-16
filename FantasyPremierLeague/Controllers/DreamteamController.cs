using FantasyPremierLeague.DataAcces;
using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.bootstrap_static;
using FantasyPremierLeague.Models.dream_team;
using FantasyPremierLeague.Models.event_live;
using FantasyPremierLeague.Models.fixtures.fixtures;
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
        public DreamteamController()
        {

        }

        #region Methods

        #endregion

        public async Task<IActionResult> Index()
        {
            var data = await ApiOperations.GetBootstrapStatic();

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
            var data = await ApiOperations.GetBootstrapStatic();

            var fixtures_list = await ApiOperations.GetFixtures(false);

            var dreamteam_data = await ApiOperations.GetDreamTeam(id);

            var dreamteam = dreamteam_data.team.ToList();

            var elements_list = data.elements.ToList();
            var teams_list = data.teams.ToList();

            foreach (var item in dreamteam)
            {
                var element = elements_list.First(x => x.id == item.element);
                var element_team = teams_list.First(x => x.id == element.team);

                item.first_name_and_web_name = $"{element.first_name} {element.web_name}";
                item.team_id = element_team.id;
                item.team_name = element_team.name;
            }

            var event_live_data = await ApiOperations.GetEventLive(id);

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
            };

            return View(viewModel);
        }
    }
}
