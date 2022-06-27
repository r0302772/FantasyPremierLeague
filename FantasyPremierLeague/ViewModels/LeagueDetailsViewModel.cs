using FantasyPremierLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class LeagueDetailsViewModel
    {
        public League league { get; set; }
        public List<Result> results_standings_list { get; set; }
    }
}
