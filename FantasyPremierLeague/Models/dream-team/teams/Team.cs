using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.dream_team.teams
{
    public class Team
    {
        public int element { get; set; }
        public int points { get; set; }
        public int position { get; set; }

        //extra props
        public string first_name_and_web_name { get; set; }
        public int team_id { get; set; }
        public string team_name { get; set; }
    }
}
