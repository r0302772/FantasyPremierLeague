using FantasyPremierLeague.Models.fixtures.fixtures.lists_and_objects.stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.fixtures.fixtures
{
    public class Fixture
    {
        public int code { get; set; }
        public int? Event { get; set; }
        public bool finished { get; set; }
        public bool finished_provisional { get; set; }
        public int id { get; set; }
        public DateTime? kickoff_time { get; set; }
        public int minutes { get; set; }
        public bool provisional_start_time { get; set; }
        public bool? started { get; set; }
        public int team_a { get; set; }
        public int? team_a_score { get; set; }
        public int team_h { get; set; }
        public int? team_h_score { get; set; }
        public List<Stat> stats { get; set; }
        public int team_h_difficulty { get; set; }
        public int team_a_difficulty { get; set; }
        public int pulse_id { get; set; }

        //extra props
        public string team_h_name { get; set; }
        public string team_a_name { get; set; }
        public string predicted_winner { get; set; }
        public string actual_winner { get; set; }
    }
}