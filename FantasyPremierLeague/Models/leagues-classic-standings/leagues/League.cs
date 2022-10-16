using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.leagues_classic_standings.leagues
{
    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created { get; set; }
        public bool closed { get; set; }
        public object max_entries { get; set; }
        public string league_type { get; set; }
        public string scoring { get; set; }
        public int admin_entry { get; set; }
        public int start_event { get; set; }
        public string code_privacy { get; set; }
        public bool has_cup { get; set; }
        public object cup_league { get; set; }
        public object rank { get; set; }
    }
}
