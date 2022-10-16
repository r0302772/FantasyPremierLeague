using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.dream_team.teams;
using FantasyPremierLeague.Models.event_live.elements;
using FantasyPremierLeague.Models.fixtures.fixtures;
using System.Collections.Generic;

namespace FantasyPremierLeague.ViewModels
{
    public class DreamteamDetailViewModel
    {
        public List<Team> dreamteam { get; set; }
        public List<Element> dreamteam_prediction { get; set; }
    }
}
