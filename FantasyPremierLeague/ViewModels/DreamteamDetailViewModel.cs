using FantasyPremierLeague.Models;
using System.Collections.Generic;

namespace FantasyPremierLeague.ViewModels
{
    public class DreamteamDetailViewModel
    {
        public List<Dreamteam> team { get; set; }
        public List<Element> Players { get; set; }

        public List<Element> prediction { get; set; }
    }
}
