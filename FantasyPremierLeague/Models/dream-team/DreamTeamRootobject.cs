using FantasyPremierLeague.Models.dream_team.teams;
using FantasyPremierLeague.Models.dream_team.top_players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.dream_team
{
    //Endpoint path: dream-team/{event_id}/
    public class DreamTeamRootobject
    {
        public Top_Player top_player { get; set; }
        public List<Team> team { get; set; }
    }
}
