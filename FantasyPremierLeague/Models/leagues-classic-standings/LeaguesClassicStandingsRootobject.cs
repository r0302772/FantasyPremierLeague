using FantasyPremierLeague.Models.leagues_classic_standings.leagues;
using FantasyPremierLeague.Models.leagues_classic_standings.new_entries;
using FantasyPremierLeague.Models.leagues_classic_standings.standings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.leagues_classic_standings
{
    //Endpoint path: leagues-classic/{league_id}/standings
    public class LeaguesClassicStandingsRootobject
    {
        public New_Entry new_entries { get; set; }
        public DateTime last_updated_data { get; set; }
        public League league { get; set; }
        public Standing standings { get; set; }
    }
}
