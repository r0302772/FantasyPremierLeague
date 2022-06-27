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
        #region API GetRequests
        [NonAction]
        public async Task<Rootobject> GetBootstrapStatic()
        {
            Rootobject bootstrap_static;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bootstrap_static = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            return bootstrap_static;
        }

        [NonAction]
        public async Task<List<Fixture>> GetFixtures()
        {
            List<Fixture> fixtures_list;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtures_list = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            return fixtures_list;
        }

        [NonAction]
        public async Task<List<Fixture>> GetFixturesByTeamId(int? id)
        {
            List<Fixture> fixtures_list;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtures_list = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            fixtures_list = fixtures_list.Where(x => x.team_h == id || x.team_a == id).ToList();

            return fixtures_list;
        }
        #endregion

        public async Task<IActionResult> Index(string sortOrder)
        {
            var data = GetBootstrapStatic().Result;

            var teams_list = data.teams.ToList();

            #region sortOrder
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name";
            ViewData["StrengthSortParm"] = sortOrder == "strength" ? "strength_desc" : "strength";
            ViewData["StrengthOverallHomeSortParm"] = sortOrder == "strength_overall_home" ? "strength_overall_home_desc" : "strength_overall_home";
            ViewData["StrengthAttackHomeSortParm"] = sortOrder == "strength_attack_home" ? "strength_attack_home_desc" : "strength_attack_home";
            ViewData["StrengthDefenceHomeSortParm"] = sortOrder == "strength_defence_home" ? "strength_defence_home_desc" : "strength_defence_home";
            ViewData["StrengthOverallAwaySortParm"] = sortOrder == "strength_overall_away" ? "strength_overall_away_desc" : "strength_overall_away";
            ViewData["StrengthAttackAwaySortParm"] = sortOrder == "strength_attack_away" ? "strength_attack_away_desc" : "strength_attack_away";
            ViewData["StrengthDefenceAwaySortParm"] = sortOrder == "strength_defence_away" ? "strength_defence_away_desc" : "strength_defence_away";

            teams_list = sortOrder switch
            {
                "name_desc" => teams_list.OrderByDescending(x => x.name).ToList(),
                "name" => teams_list.OrderBy(x => x.name).ToList(),
                "strength_desc" => teams_list.OrderByDescending(x => x.strength).ToList(),
                "strength" => teams_list.OrderBy(x => x.strength).ToList(),
                "strength_overall_home_desc" => teams_list.OrderByDescending(x => x.strength_overall_home).ToList(),
                "strength_overall_home" => teams_list.OrderBy(x => x.strength_overall_home).ToList(),
                "strength_attack_home_desc" => teams_list.OrderByDescending(x => x.strength_attack_home).ToList(),
                "strength_attack_home" => teams_list.OrderBy(x => x.strength_attack_home).ToList(),
                "strength_defence_home_desc" => teams_list.OrderByDescending(x => x.strength_defence_home).ToList(),
                "strength_defence_home" => teams_list.OrderBy(x => x.strength_defence_home).ToList(),
                "strength_overall_away_desc" => teams_list.OrderByDescending(x => x.strength_overall_away).ToList(),
                "strength_overall_away" => teams_list.OrderBy(x => x.strength_overall_away).ToList(),
                "strength_attack_away_desc" => teams_list.OrderByDescending(x => x.strength_attack_away).ToList(),
                "strength_attack_away" => teams_list.OrderBy(x => x.strength_attack_away).ToList(),
                "strength_defence_away_desc" => teams_list.OrderByDescending(x => x.strength_defence_away).ToList(),
                "strength_defence_away" => teams_list.OrderBy(x => x.strength_defence_away).ToList(),
                _ => teams_list.OrderBy(x => x.name).ToList(),
            };
            #endregion

            TeamListViewModel viewModel = new TeamListViewModel()
            {
                teams_list = teams_list
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = GetBootstrapStatic().Result;

            var team = data.teams.FirstOrDefault(x => x.id == id);

            if (team == null)
            {
                return NotFound();
            }

            var fixtures_list = GetFixturesByTeamId(id).Result;

            foreach (var fixture in fixtures_list)
            {
                if (fixture.team_h == team.id)
                {
                    team.played++;
                    team.goals_for += fixture.team_h_score;
                    team.goals_against += fixture.team_a_score;
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
                    team.played++;
                    team.goals_for += fixture.team_a_score;
                    team.goals_against += fixture.team_h_score;
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
                team.points = team.win * 3 + team.draw;
            }

            var playersOfTeam = data.elements.Where(x => x.team == team.id)
                                             .OrderBy(x => x.element_type)
                                             .ToList();

            var cornersAndIndirectFreekickTakers = playersOfTeam.Where(x =>
                                            x.corners_and_indirect_freekicks_order != null)
                                            .OrderBy(x => x.corners_and_indirect_freekicks_order)
                                            .ToList();

            var directFreekickTakers = playersOfTeam.Where(x =>
                                            x.direct_freekicks_order != null)
                                            .OrderBy(x => x.direct_freekicks_order)
                                            .ToList();

            var penaltyTakers = playersOfTeam.Where(x =>
                                            x.penalties_order != null)
                                            .OrderBy(x => x.penalties_order)
                                            .ToList();

            TeamDetailsViewModel viewModel = new TeamDetailsViewModel()
            {
                PlayersOfTeam = playersOfTeam,
                CornersAndIndirectFreekickTakers = cornersAndIndirectFreekickTakers,
                DirectFreekickTakers = directFreekickTakers,
                PenaltyTakers = penaltyTakers,
                //team = team
                short_name = team.short_name,
                name = team.name,
                played = team.played,
                win = team.win,
                draw = team.draw,
                loss = team.loss,
                goals_for = team.goals_for,
                goals_against = team.goals_against,
                goal_difference = team.goal_difference,
                points = team.points,
                form = team.form,

                #region Team Strength
                strength = team.strength,
                strength_overall_home = team.strength_overall_home,
                strength_overall_away = team.strength_overall_away,
                strength_attack_home = team.strength_attack_home,
                strength_attack_away = team.strength_attack_away,
                strength_defence_home = team.strength_defence_home,
                strength_defence_away = team.strength_defence_away
                #endregion
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Standings(string sortOrder)
        {
            var data = GetBootstrapStatic().Result;

            var teams_list = data.teams.ToList();

            var fixtures_list = GetFixtures().Result;

            foreach (var team in teams_list)
            {
                foreach (var fixture in fixtures_list)
                {
                    if (fixture.team_h == team.id)
                    {
                        team.played++;
                        team.goals_for += fixture.team_h_score;
                        team.goals_against += fixture.team_a_score;
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
                        team.played++;
                        team.goals_for += fixture.team_a_score;
                        team.goals_against += fixture.team_h_score;
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
                team.points = team.win * 3 + team.draw;
            }

            #region sortOrder
            ViewData["CurrentSort"] = sortOrder;
            ViewData["PointsSortParm"] = sortOrder == "points" ? "points_desc" : "points";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            ViewData["PlayedSortParm"] = sortOrder == "played_desc" ? "played" : "played_desc";
            ViewData["WinSortParm"] = sortOrder == "win_desc" ? "win" : "win_desc";
            ViewData["DrawSortParm"] = sortOrder == "draw_desc" ? "draw" : "draw_desc";
            ViewData["LossSortParm"] = sortOrder == "loss_desc" ? "loss" : "loss_desc";
            ViewData["GoalsForSortParm"] = sortOrder == "goals_for_desc" ? "goals_for" : "goals_for_desc";
            ViewData["GoalsAgainstSortParm"] = sortOrder == "goals_against_desc" ? "goals_against" : "goals_against_desc";
            ViewData["GoalDifferenceSortParm"] = sortOrder == "goal_difference_desc" ? "goal_difference" : "goal_difference_desc";
            //ViewData["PositionSortParm"] = sortOrder == "position" ? "position_desc" : "position";

            teams_list = sortOrder switch
            {
                "points_desc" => teams_list.OrderByDescending(x => x.points).ToList(),
                "points" => teams_list.OrderBy(x => x.points).ToList(),
                "name_desc" => teams_list.OrderByDescending(x => x.name).ToList(),
                "name" => teams_list.OrderBy(x => x.name).ToList(),
                "played_desc" => teams_list.OrderByDescending(x => x.played).ToList(),
                "played" => teams_list.OrderBy(x => x.played).ToList(),
                "win_desc" => teams_list.OrderByDescending(x => x.win).ToList(),
                "win" => teams_list.OrderBy(x => x.win).ToList(),
                "draw_desc" => teams_list.OrderByDescending(x => x.draw).ToList(),
                "draw" => teams_list.OrderBy(x => x.draw).ToList(),
                "loss_desc" => teams_list.OrderByDescending(x => x.loss).ToList(),
                "loss" => teams_list.OrderBy(x => x.loss).ToList(),
                "goals_for_desc" => teams_list.OrderByDescending(x => x.goals_for).ToList(),
                "goals_for" => teams_list.OrderBy(x => x.goals_for).ToList(),
                "goals_against_desc" => teams_list.OrderByDescending(x => x.goals_against).ToList(),
                "goals_against" => teams_list.OrderBy(x => x.goals_against).ToList(),
                "goal_difference_desc" => teams_list.OrderByDescending(x => x.goal_difference).ToList(),
                "goal_difference" => teams_list.OrderBy(x => x.goal_difference).ToList(),
                //"position_desc" => teams_list.OrderByDescending(x => x.position).ToList(),
                //"position" => teams_list.OrderBy(x => x.position).ToList(),
                _ => teams_list.OrderByDescending(x => x.points).ToList(),
            };
            #endregion

            TeamListViewModel viewModel = new TeamListViewModel()
            {
                teams_list = teams_list
            };

            return View(viewModel);
        }
    }
}
