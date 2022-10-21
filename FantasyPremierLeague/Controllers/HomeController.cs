using FantasyPremierLeague.DataAcces;
using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.bootstrap_static.events;
using FantasyPremierLeague.Models.bootstrap_static.events.lists_and_objects;
using FantasyPremierLeague.Models.dream_team.teams;
using FantasyPremierLeague.Models.entry_event_picks.picks;
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

        //[Route("/")]
        public async Task<IActionResult> Index()
        {
            //unitOfWork
            //var bootstrap = await _uow.BootstrapStaticRepository.Get("bootstrap-static/");
            //var event_status = await _uow.BootstrapStaticRepository.Get("event-status/");

            var bootstrap_static_rootobject = await ApiOperations.GetBootstrapStatic();

            var events_list = bootstrap_static_rootobject.events.ToList();
            var elements_list = bootstrap_static_rootobject.elements.ToList();
            var teams_list = bootstrap_static_rootobject.teams.ToList();
            var element_types_list = bootstrap_static_rootobject.element_types.ToList();

            //var my_team_rootobject = await ApiOperations.GetMyTeam(395399);
            //var my_team_list = my_team_rootobject.picks.ToList();

            #region event_status
            var event_status_rootobject = await ApiOperations.GetEventStatus();
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
                        { "bonus_added", bonus_added}
                });
            }
            #endregion

            #region event_info
            var current_event = bootstrap_static_rootobject.events.First(x => x.is_current);

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

            foreach (var item in current_event.GetType().GetProperties())
            {

            }

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

            #region my_team
            var entry_event_picks_rootobject = await ApiOperations.GetEntryEventPicks(395399, current_event.id);
            var event_live_rootobject = await ApiOperations.GetEventLive(current_event.id);

            var picks = entry_event_picks_rootobject.picks.ToList();
            var event_live_elements_list = event_live_rootobject.elements.ToList();
            int my_team_total_points = 0;
            int my_bench_total_points = 0;

            var my_team = new Dictionary<Pick, Hashtable>();

            foreach (var item in picks)
            {
                var element = elements_list.First(x => x.id == item.element);
                var element_team = teams_list.First(x => x.id == element.team);
                var element_type = element_types_list.First(x => x.id == element.element_type);
                var event_element = event_live_elements_list.First(x => x.id == item.element);

                string chance_of_playing_icon;
                string chance_of_playing_icon_color;

                switch (element.chance_of_playing_next_round)
                {
                    case 0:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 25:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 50:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 75:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 100:
                        chance_of_playing_icon = "bi bi-hand-thumbs-up-fill";
                        chance_of_playing_icon_color = "text-success";
                        break;
                    default:
                        chance_of_playing_icon = "bi bi-question-circle";
                        chance_of_playing_icon_color = "text-secondary";
                        break;
                }

                string captain_or_vice_captian = "";

                if (item.is_captain)
                {
                    captain_or_vice_captian = "C";
                }
                else if (item.is_vice_captain)
                {
                    captain_or_vice_captian = "VC";
                }

                my_team.Add(item, new Hashtable() {
                        { "element_type_singular_name_short", element_type.singular_name_short },
                        { "element_web_name", element.web_name },
                        { "element_team_id", element_team.id },
                        { "element_team_name", element_team.name + ".png" },
                        { "element_team_short_name", element_team.short_name },
                        { "event_element_stats_total_points", event_element.stats.total_points *= (item.position <= 11) ? item.multiplier : 1},
                        { "chance_of_playing_icon", chance_of_playing_icon },
                        { "chance_of_playing_icon_color", chance_of_playing_icon_color },
                        { "element_news", element.news },
                        { "captain_or_vice_captian", captain_or_vice_captian },
                });

                if (item.position <= 11)
                {
                    my_team_total_points += event_element.stats.total_points;
                }
                else
                {
                    my_bench_total_points += event_element.stats.total_points;
                }
            }

            #endregion

            #region team_of_the_week
            var dream_team_rootobject = await ApiOperations.GetDreamTeam(current_event.id);
            var dream_team_list = dream_team_rootobject.team.ToList();

            var team_of_the_week = new Dictionary<Team, Hashtable>();
            int team_of_the_week_total_points = 0;

            foreach (var item in dream_team_list)
            {
                var element = elements_list.First(x => x.id == item.element);
                var element_team = teams_list.First(x => x.id == element.team);
                var element_type = element_types_list.First(x => x.id == element.element_type);

                var king_of_the_week = (item.points == dream_team_list.Max(x => x.points)) ? "fa-solid fa-crown" : " ";

                string chance_of_playing_icon;
                string chance_of_playing_icon_color;

                switch (element.chance_of_playing_next_round)
                {
                    case 0:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 25:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 50:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 75:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 100:
                        chance_of_playing_icon = "bi bi-hand-thumbs-up-fill";
                        chance_of_playing_icon_color = "text-success";
                        break;
                    default:
                        chance_of_playing_icon = "bi bi-question-circle";
                        chance_of_playing_icon_color = "text-secondary";
                        break;
                }

                team_of_the_week.Add(item, new Hashtable() {
                        { "element_type_singular_name_short", element_type.singular_name_short },
                        { "element_web_name", element.web_name },
                        { "element_team_id", element_team.id },
                        { "element_team_name", element_team.name + ".png" },
                        { "element_team_short_name", element_team.short_name },
                        { "king_of_the_week", king_of_the_week },
                        { "chance_of_playing_icon", chance_of_playing_icon },
                        { "chance_of_playing_icon_color", chance_of_playing_icon_color },
                });

                team_of_the_week_total_points += item.points;
            }
            #endregion

            #region top_transfers_in_and_out
            var top_transfers_in_list = elements_list.OrderByDescending(x => x.transfers_in_event).Take(10).ToList();
            var top_transfers_in = new Dictionary<Element, Hashtable>();

            foreach (var element in top_transfers_in_list)
            {
                var element_team = teams_list.First(x => x.id == element.team);
                var element_type = element_types_list.First(x => x.id == element.element_type);
                element.now_cost = (element.now_cost / 10);
                element.cost_change_event = (element.cost_change_event / 10);

                var pick = entry_event_picks_rootobject.picks.Find(x => x.element == element.id);
                string already_owend = (pick != null) ? "bi bi-star-fill" : "bi bi-star";

                string chance_of_playing_icon;
                string chance_of_playing_icon_color;

                switch (element.chance_of_playing_next_round)
                {
                    case 0:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 25:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 50:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 75:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 100:
                        chance_of_playing_icon = "bi bi-hand-thumbs-up-fill";
                        chance_of_playing_icon_color = "text-success";
                        break;
                    default:
                        chance_of_playing_icon = "bi bi-question-circle";
                        chance_of_playing_icon_color = "text-secondary";
                        break;
                }

                top_transfers_in.Add(element, new Hashtable() {
                        { "element_type_singular_name_short", element_type.singular_name_short },
                        { "element_web_name", element.web_name },
                        { "element_team_id", element_team.id },
                        { "element_team_name", element_team.name + ".png" },
                        { "element_team_short_name", element_team.short_name },
                        { "chance_of_playing_icon", chance_of_playing_icon },
                        { "chance_of_playing_icon_color", chance_of_playing_icon_color },
                        { "already_owned", already_owend },
                });
            }

            var top_transfers_out_list = elements_list.OrderByDescending(x => x.transfers_out_event).Take(10).ToList();
            var top_transfers_out = new Dictionary<Element, Hashtable>();

            foreach (var element in top_transfers_out_list)
            {
                var element_team = teams_list.First(x => x.id == element.team);
                var element_type = element_types_list.First(x => x.id == element.element_type);
                element.now_cost = (element.now_cost / 10);
                element.cost_change_event = (element.cost_change_event / 10);

                var pick = entry_event_picks_rootobject.picks.Find(x => x.element == element.id);
                string already_owend = (pick != null) ? "bi bi-star-fill" : "bi bi-star";

                string chance_of_playing_icon;
                string chance_of_playing_icon_color;

                switch (element.chance_of_playing_next_round)
                {
                    case 0:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 25:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-danger";
                        break;
                    case 50:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 75:
                        chance_of_playing_icon = "bi bi-exclamation-triangle-fill";
                        chance_of_playing_icon_color = "text-warning";
                        break;
                    case 100:
                        chance_of_playing_icon = "bi bi-hand-thumbs-up-fill";
                        chance_of_playing_icon_color = "text-success";
                        break;
                    default:
                        chance_of_playing_icon = "bi bi-question-circle";
                        chance_of_playing_icon_color = "text-secondary";
                        break;
                }

                top_transfers_out.Add(element, new Hashtable() {
                        { "element_type_singular_name_short", element_type.singular_name_short },
                        { "element_web_name", element.web_name },
                        { "element_team_id", element_team.id },
                        { "element_team_name", element_team.name + ".png" },
                        { "element_team_short_name", element_team.short_name },
                        { "chance_of_playing_icon", chance_of_playing_icon },
                        { "chance_of_playing_icon_color", chance_of_playing_icon_color },
                        { "already_owned", already_owend },
                });
            }
            #endregion

            #region ViewModel
            HomeViewModel viewModel = new HomeViewModel()
            {
                event_status_rootobject = event_status_rootobject,
                event_status = event_status,
                event_info = event_info,
                my_team = my_team,
                my_team_total_points = my_team_total_points,
                my_bench_total_points = my_bench_total_points,
                team_of_the_week = team_of_the_week,
                team_of_the_week_total_points = team_of_the_week_total_points,
                top_transfers_in = top_transfers_in,
                top_transfers_out = top_transfers_out
            };

            #endregion

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
