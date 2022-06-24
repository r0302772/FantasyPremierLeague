using FantasyPremierLeague.Models;
using FantasyPremierLeague.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            BootstrapStatic data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            Fixture[] fixtureList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<Fixture[]>(apiResponse);
            }

            var teams = data.teams.ToArray();

            foreach (var team in teams)
            {
                foreach (var fixture in fixtureList)
                {
                    if (fixture.team_h == team.id)
                    {
                        if (fixture.team_h_score > fixture.team_a_score)
                        {
                            team.win++;
                        }
                        else if (fixture.team_h_score == fixture.team_a_score)
                        {
                            team.draw++;
                        }
                        else
                        {
                            team.loss++;
                        }
                    }
                    else if (fixture.team_a == team.id)
                    {
                        if (fixture.team_a_score > fixture.team_h_score)
                        {
                            team.win++;
                        }
                        else if (fixture.team_a_score == fixture.team_h_score)
                        {
                            team.draw++;
                        }
                        else
                        {
                            team.loss++;
                        }
                    }
                }

            }

            TeamListViewModel viewModel = new TeamListViewModel()
            {
                teams = teams.OrderByDescending(x => x.total_points).ToArray()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BootstrapStatic data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<BootstrapStatic>(apiResponse);
                }
            }

            var team = data.teams.FirstOrDefault(x => x.id == id);
            if (team == null)
            {
                return NotFound();
            }

            Fixture[] fixtureList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<Fixture[]>(apiResponse);
            }

            foreach (var fixture in fixtureList)
            {
                if (fixture.team_h == team.id)
                {
                    if (fixture.team_h_score > fixture.team_a_score)
                    {
                        team.win++;
                    }
                    else if (fixture.team_h_score == fixture.team_a_score)
                    {
                        team.draw++;
                    }
                    else
                    {
                        team.loss++;
                    }
                }
                else if (fixture.team_a == team.id)
                {
                    if (fixture.team_a_score > fixture.team_h_score)
                    {
                        team.win++;
                    }
                    else if (fixture.team_a_score == fixture.team_h_score)
                    {
                        team.draw++;
                    }
                    else
                    {
                        team.loss++;
                    }
                }
            }

            var playersOfTeam = data.elements.Where(x => x.team == team.id).OrderBy(x => x.element_type).ToArray();
            //var gk = playersOfTeam.Where(x => x.element_type == 1).ToArray();
            //var def = playersOfTeam.Where(x => x.element_type == 2).ToArray();
            //var mid = playersOfTeam.Where(x => x.element_type == 3).ToArray();
            //var fwd = playersOfTeam.Where(x => x.element_type == 4).ToArray();
            //var setPieceTakers = playersOfTeam.Where(x => 
            //                                         x.corners_and_indirect_freekicks_order != null ||
            //                                         x.direct_freekicks_order !=null ||
            //                                         x.penalties_order != null
            //                                         ).ToArray();
            var cornersAndIndirectFreekickTakers = playersOfTeam.Where(x =>
                                            x.corners_and_indirect_freekicks_order != null)
                                            .OrderBy(x => x.corners_and_indirect_freekicks_order).ToArray();
            var directFreekickTakers = playersOfTeam.Where(x =>
                                            x.direct_freekicks_order != null)
                                            .OrderBy(x => x.direct_freekicks_order).ToArray();
            var penaltyTakers = playersOfTeam.Where(x =>
                                            x.penalties_order != null)
                                            .OrderBy(x => x.penalties_order).ToArray();

            TeamDetailsViewModel viewModel = new TeamDetailsViewModel()
            {
                PlayersOfTeam = playersOfTeam,
                CornersAndIndirectFreekickTakers = cornersAndIndirectFreekickTakers,
                DirectFreekickTakers = directFreekickTakers,
                PenaltyTakers = penaltyTakers,
                name = team.name,
                short_name = team.short_name,
                //position = team.position,
                win = team.win,
                draw = team.draw,
                loss = team.loss,
                total_points = team.total_points
                //strength = team.strength,
                //strength_overall_home = team.strength_overall_home,
                //strength_overall_away = team.strength_overall_away,
                //strength_attack_home = team.strength_attack_home,
                //strength_attack_away = team.strength_attack_away,
                //strength_defence_home = team.strength_defence_home,
                //strength_defence_away = team.strength_defence_away,
                //unavailable = team.unavailable
            };

            return View(viewModel);
        }
    }
}
