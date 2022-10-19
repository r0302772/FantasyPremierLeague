using FantasyPremierLeague.DataAcces;
using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.bootstrap_static.events;
using FantasyPremierLeague.Models.bootstrap_static.events.lists_and_objects;
using FantasyPremierLeague.Models.dream_team.teams;
using FantasyPremierLeague.Models.event_status.statuses;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUnitOfWork _uow;
        public HomeController(/*IUnitOfWork uow*/)
        {
            //_uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            //unitOfWork
            //var bootstrap = await _uow.BootstrapStaticRepository.Get("bootstrap-static/");
            //var event_status = await _uow.BootstrapStaticRepository.Get("event-status/");

            var bootstrap_static_rootobject = await ApiOperations.GetBootstrapStatic();
            var current_event = bootstrap_static_rootobject.events.First(x => x.is_current);
            var event_status_rootobject = await ApiOperations.GetEventStatus();
            var dream_team_rootobject = await ApiOperations.GetDreamTeam(current_event.id);

            var dream_team_list = dream_team_rootobject.team.ToList();
            var events_list = bootstrap_static_rootobject.events.ToList();
            var elements_list = bootstrap_static_rootobject.elements.ToList();
            var teams_list = bootstrap_static_rootobject.teams.ToList();
            var element_types_list = bootstrap_static_rootobject.element_types.ToList();

            #region event_status
            var event_status = new Dictionary<Status, Hashtable>();

            foreach (var item in event_status_rootobject.status)
            {
                string confirmed_or_live;
                switch (item.points)
                {
                    case "l":
                        confirmed_or_live = "live";
                        break;
                    case "r":
                        confirmed_or_live = "confirmed";
                        break;
                    default:
                        confirmed_or_live = "";
                        break;
                }

                string bonus_added = item.bonus_added ? "added" : "";

                event_status.Add(item, new Hashtable() {
                        { "confirmed_or_live", confirmed_or_live },
                        { "bonus_added", bonus_added}});
            }
            #endregion

            #region event_info

            var current_event_info = new Event()
            {
                name = current_event.name,
                highest_score = current_event.highest_score,
                average_entry_score = current_event.average_entry_score,
                most_transferred_in = current_event.most_transferred_in,
                most_captained = current_event.most_captained,
                most_vice_captained = current_event.most_vice_captained,
                most_selected = current_event.most_selected,
            };

            var most_transferred_in_name = elements_list.First(x => x.id == current_event.most_transferred_in).web_name;
            var most_captained_name = elements_list.First(x => x.id == current_event.most_captained).web_name;
            var most_vice_captained_name = elements_list.First(x => x.id == current_event.most_vice_captained).web_name;
            var most_selected_name = elements_list.First(x => x.id == current_event.most_selected).web_name;

            var event_info = new Dictionary<Event, Hashtable>() {
                { current_event_info,
                    new Hashtable() {
                        {"most_transferred_in_name",most_transferred_in_name },
                        {"most_captained_name",most_captained_name },
                        {"most_vice_captained_name",most_vice_captained_name },
                        {"most_selected_name",most_selected_name }
                    }
                }
            };

            #endregion

            #region player_of_the_week
            var player_of_the_week_list = new List<Top_Element_Info>();
            foreach (var item in events_list)
            {
                player_of_the_week_list.Add(item.top_element_info);
            }
            #endregion

            #region team_of_the_week
            var team_of_the_week = new Dictionary<Team, Hashtable>();
            int team_of_the_week_total_points = 0;

            foreach (var item in dream_team_list)
            {
                var element = elements_list.First(x => x.id == item.element);
                var element_team = teams_list.First(x => x.id == element.team);
                var element_type = element_types_list.First(x => x.id == element.element_type);

                team_of_the_week.Add(
                    item, new Hashtable() {
                        { "element_type_singular_name_short", element_type.singular_name_short },
                        { "element_web_name", element.web_name },
                        { "element_team_id", element_team.id },
                        { "element_team_short_name", element_team.short_name },
                    }
                    );

                team_of_the_week_total_points += item.points;
            }
            #endregion

            #region top_transfers_in_and_out
            var top_transfers_in = elements_list.OrderByDescending(x => x.transfers_in_event).Take(5).ToList();
            foreach (var item in top_transfers_in)
            {

            }
            var top_transfers_out = elements_list.OrderByDescending(x => x.transfers_out_event).Take(5).ToList();
            foreach (var item in top_transfers_in)
            {

            }
            #endregion

            HomeViewModel viewModel = new HomeViewModel()
            {
                event_status_rootobject = event_status_rootobject,
                event_status = event_status,
                event_info = event_info,
                player_of_the_week_list = player_of_the_week_list,
                team_of_the_week = team_of_the_week,
                team_of_the_week_total_points = team_of_the_week_total_points,
                top_transfers_in = top_transfers_in,
                top_transfers_out = top_transfers_out
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
