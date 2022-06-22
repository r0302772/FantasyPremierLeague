using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }

        public int position { get; set; }

        public int win { get; set; }
        public int draw { get; set; }
        public int loss { get; set; }

        public int total_points
        {
            get
            {
                return win * 3 + draw;
            }
        }

        public int strength { get; set; }
        public int strength_overall_home { get; set; }
        public int strength_overall_away { get; set; }
        public int strength_attack_home { get; set; }
        public int strength_attack_away { get; set; }
        public int strength_defence_home { get; set; }
        public int strength_defence_away { get; set; }

        public bool unavailable { get; set; }
    }
}
