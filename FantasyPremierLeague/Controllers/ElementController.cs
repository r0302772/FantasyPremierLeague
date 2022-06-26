using FantasyPremierLeague.Data;
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

namespace FantasyPremierLeague.Controllers
{
    public class ElementController : Controller
    {
        public async Task<IActionResult> Index(string team_id, string element_type_id)
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

            var elements = data.elements.OrderBy(x => x.team).ThenBy(x => x.id).ToList();
            var teamsList = data.teams.ToList();
            var elementTypesList = data.element_types.ToList();

            List<SelectListItem> teamsSelectList = teamsList.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });  
            
            List<SelectListItem> elementTypesSelectList = elementTypesList.ConvertAll(x =>
            {
                return new SelectListItem()
                {
                    Text = x.singular_name,
                    Value = x.id.ToString(),
                    Selected = false
                };
            });

            if (!string.IsNullOrEmpty(team_id))
            {
                elements = elements
                                   .Where(x => x.team.ToString() == team_id)
                                   .OrderBy(x => x.element_type).ToList();
            }

            if (!string.IsNullOrEmpty(element_type_id))
            {
                elements = elements
                                   .Where(x => x.element_type.ToString() == element_type_id)
                                   .OrderBy(x => x.team).ToList();
            }

            ElementListViewModel viewModel = new ElementListViewModel()
            {
                elements = elements,
                teams = teamsSelectList,
                element_types_selectlist = elementTypesSelectList
            };


            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
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

            Rootobject summaryData;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://fantasy.premierleague.com/api/element-summary/{id}/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    summaryData = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            var element = data.elements.FirstOrDefault(x => x.id == id);
            var element_type = data.element_types.FirstOrDefault(x => x.id == element.element_type);
            var history = summaryData.history;
            var costDifference = history.Last().value - history.First().value;

            ElementDetailsViewModel viewModel = new ElementDetailsViewModel()
            {
                element_type = element_type,
                element = element,
                history = history,
                CostDifference = costDifference
            };

            return View(viewModel);
        }
    }
}
