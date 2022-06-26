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
            Rootobject data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            if (data == null) { return NotFound(); }

            var teams = data.teams.ToList();

            TeamListViewModel viewModel = new TeamListViewModel()
            {
                teams = teams
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rootobject data;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Rootobject>(apiResponse);
                }
            }

            var team = data.teams.FirstOrDefault(x => x.id == id);
            if (team == null)
            {
                return NotFound();
            }

            List<Fixture> fixtureList;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            foreach (var fixture in fixtureList)
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

                strength = team.strength,
                strength_overall_home = team.strength_overall_home,
                strength_overall_away = team.strength_overall_away,
                strength_attack_home = team.strength_attack_home,
                strength_attack_away = team.strength_attack_away,
                strength_defence_home = team.strength_defence_home,
                strength_defence_away = team.strength_defence_away
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Standings()
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

            if (data == null) { return NotFound(); }

            List<Fixture> fixtureList;

            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/fixtures/");
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtureList = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            if (fixtureList == null) { return NotFound(); }

            var teams = data.teams.ToList();

            foreach (var team in teams)
            {
                foreach (var fixture in fixtureList)
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

            TeamListViewModel viewModel = new TeamListViewModel()
            {
                teams = teams.OrderByDescending(x => x.points).ToList()
            };

            return View(viewModel);
        }
    }
}
