using FantasyPremierLeague.DataAcces;
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
using Microsoft.EntityFrameworkCore;
using FantasyPremierLeague.Models.bootstrap_static;
using FantasyPremierLeague.Models.element_summary;
using FantasyPremierLeague.Models.bootstrap_static.elements;

namespace FantasyPremierLeague.Controllers
{
    public class ElementController : Controller
    {
        public ElementController()
        {

        }
        public async Task<IActionResult> Index()
        {
            var data = await ApiOperations.GetBootstrapStatic();

            var teams_list = data.teams.ToList();
            var element_types_list = data.element_types.ToList();
            var elements_list = new List<Element>();

            #region SelectLists
            List<SelectListItem> teams_selectlist = teams_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            List<SelectListItem> element_types_selectlist = element_types_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.singular_name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });
            #endregion

            ElementListViewModel viewModel = new ElementListViewModel()
            {
                elements_list = elements_list,
                teams_selectlist = teams_selectlist,
                element_types_selectlist = element_types_selectlist
            };


            return View(viewModel);
        }

        public async Task<IActionResult> Filter(string team_id,
                                       string element_type_id,
                                       string search_string)
        {
            ViewData["CurrentFilter"] = search_string;

            var data = await ApiOperations.GetBootstrapStatic();

            var elements_list = data.elements.OrderBy(x => x.team).ThenBy(x => x.id).ToList();
            var teams_list = data.teams.ToList();
            var element_types_list = data.element_types.ToList();

            #region SelectLists
            List<SelectListItem> teams_selectlist = teams_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            List<SelectListItem> element_types_selectlist = element_types_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.singular_name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });
            #endregion

            #region SearchParams
            if (!string.IsNullOrEmpty(team_id))
            {
                elements_list = elements_list.Where(x => x.team.ToString() == team_id)
                                             .OrderBy(x => x.element_type)
                                             .ToList();
            }

            if (!string.IsNullOrEmpty(element_type_id))
            {
                elements_list = elements_list.Where(x => x.element_type.ToString() == element_type_id)
                                             .OrderBy(x => x.team)
                                             .ToList();
            }

            if (!string.IsNullOrEmpty(search_string))
            {
                elements_list = elements_list.Where(x => x.first_name.ToLower().Contains(search_string.ToLower()) ||
                                                        x.web_name.ToLower().Contains(search_string.ToLower()))
                                            .ToList();
            }
            #endregion

            foreach (var item in elements_list)
            {
                item.first_name_and_web_name = $"{item.first_name} {item.web_name}";
                item.element_type_short_name = element_types_list.First(x => x.id == item.element_type).singular_name_short;
                item.team_name = teams_list.First(x => x.id == item.team).name;
            }

            ElementListViewModel viewModel = new ElementListViewModel()
            {
                elements_list = elements_list,
                teams_selectlist = teams_selectlist,
                element_types_selectlist = element_types_selectlist
            };


            return View("Index", viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = await ApiOperations.GetBootstrapStatic();

            var element_summary = await ApiOperations.GetElementSummary(id);
            var teams_list = data.teams.ToList();
            var element = data.elements.FirstOrDefault(x => x.id == id);
            var element_team_name = data.teams.First(x => x.id == element.team).name;
            var element_type = data.element_types.FirstOrDefault(x => x.id == element.element_type);
            var element_history = element_summary.history;
            var element_fixtures = element_summary.fixtures;
            var value_difference = element_history.Last().value - element_history.First().value;

            foreach (var item in element_history)
            {
                item.opponent_team_name = teams_list.First(x => x.id == item.opponent_team).name;
                if (item.was_home)
                {
                    item.h_or_a = "h".ToUpper();
                }
                else
                {
                    item.h_or_a = "a".ToUpper();
                }
            }

            foreach (var item in element_fixtures)
            {
                var opponent = teams_list.First(x => x.id == item.team_h);
                //item.opponent_team = opponent.id;
                item.opponent_team_name = opponent.name;

                if (item.is_home)
                {
                    opponent = teams_list.First(x => x.id == item.team_a);
                    item.opponent_team = opponent.id;
                    item.opponent_team_name = opponent.name;
                }
            }

            ElementDetailsViewModel viewModel = new ElementDetailsViewModel()
            {
                element = element,
                element_team_name = element_team_name,
                element_type = element_type,
                element_history = element_history,
                element_fixtures = element_fixtures,
                value_difference = value_difference,
                total_minutes = element_history.Count * 90
            };

            return View(viewModel);
        }

        public async Task<IActionResult> SetPieceTakers(string team_id,
                                                        string element_type_id,
                                                        string set_piece_id)
        {
            var data = await ApiOperations.GetBootstrapStatic();

            var teams_list = data.teams.ToList();
            var teams_count = teams_list.Count();

            var element_types_list = data.element_types.ToList();
            var element_types_count = element_types_list.Count();

            var elements_list = data.elements.Where(x => x.corners_and_indirect_freekicks_order != null ||
                                                    x.direct_freekicks_order != null ||
                                                    x.penalties_order != null).ToList();
            var elements_count = elements_list.Count();

            #region SelectLists
            List<SelectListItem> teams_selectlist = teams_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(team_id))
            {
                elements_list = elements_list
                                   .Where(x => x.team.ToString() == team_id)
                                   //.OrderByDescending(x => double.Parse(x.ict_index))
                                   //.ThenBy(x => x.element_type)
                                   .ToList();
            }

            List<SelectListItem> element_types_selectlist = element_types_list.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.singular_name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(element_type_id))
            {
                elements_list = elements_list
                                   .Where(x => x.element_type.ToString() == element_type_id)
                                   .OrderBy(x => x.team).ToList();
            }

            List<SelectListItem> set_piece_selectlist = new List<SelectListItem>()
            {
            new SelectListItem{Text = "Penalties", Value ="1", Selected = false },
            new SelectListItem{Text = "Direct Freekicks", Value ="2", Selected = false },
            new SelectListItem{Text = "Corners & Indirect Freekicks", Value ="3", Selected = false },
            };

            if (!string.IsNullOrEmpty(set_piece_id))
            {
                if (set_piece_id == "1")
                {
                    elements_list = elements_list
                                       .Where(x => x.penalties_order != null)
                                       .OrderBy(x => x.penalties_order)
                                       //.ThenByDescending(x => double.Parse(x.ict_index))
                                       .ToList();
                }
                else if (set_piece_id == "2")
                {
                    elements_list = elements_list
                                       .Where(x => x.direct_freekicks_order != null)
                                       .OrderBy(x => x.direct_freekicks_order)
                                       //.ThenByDescending(x => double.Parse(x.ict_index))
                                       .ToList();
                }
                else if (set_piece_id == "3")
                {
                    elements_list = elements_list
                                       .Where(x => x.corners_and_indirect_freekicks_order != null)
                                       .OrderBy(x => x.corners_and_indirect_freekicks_order)
                                       //.ThenByDescending(x => double.Parse(x.ict_index))
                                       .ToList();
                }
            }
            #endregion

            ElementListViewModel viewModel = new ElementListViewModel()
            {
                teams_selectlist = teams_selectlist,
                element_types_selectlist = element_types_selectlist,
                set_piece_selectlist = set_piece_selectlist,
                elements_list = elements_list,
            };

            return View(viewModel);
        }
    }
}
