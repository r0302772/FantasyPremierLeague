using FantasyPremierLeague.Models;
using System.Collections.Generic;

namespace FantasyPremierLeague.ViewModels
{
    public class DreamteamDetailViewModel
    {
        public List<Dreamteam> dreamteam { get; set; }
        public List<Element> dreamteam_prediction { get; set; }

        public List<Fixture> fixtures_list { get; set; }
    }
}
